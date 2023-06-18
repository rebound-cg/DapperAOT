﻿using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Dapper.Internal.Roslyn;

internal static class TypeSymbolExtensions
{
    public static bool InNamespace(this ITypeSymbol? typeSymbol, string @namespace)
    {
        if (typeSymbol is null) return false;
        return typeSymbol.ContainingNamespace?.ToDisplayString() == @namespace;
    }

    public static string? GetTypeDisplayName(this ITypeSymbol? typeSymbol)
    {
        if (typeSymbol is null) return null;
        if (typeSymbol.IsAnonymousType == true) return "object?";
        return "global::" + typeSymbol.ToDisplayString();
    }
    public static string? GetContainingTypeDisplayName(this ITypeSymbol? typeSymbol, int typeArgIndex = 0)
    {
        var containingTypeSymbol = typeSymbol.GetContainingTypeSymbol(typeArgIndex);
        return containingTypeSymbol.GetTypeDisplayName();
    }
    public static ITypeSymbol? GetContainingTypeSymbol(this ITypeSymbol? typeSymbol, int typeArgIndex = 0)
    {
        if (typeSymbol is null) return null;
        if (typeSymbol is INamedTypeSymbol namedTypeSymbol)
        {
            var typeArguments = namedTypeSymbol.TypeArguments;
            if (typeArgIndex >= typeArguments.Length) return null;
            return typeArguments[typeArgIndex];
        }
        if (typeSymbol is IArrayTypeSymbol arrayTypeSymbol)
        {
            return arrayTypeSymbol.ElementType;
        }

        return null;
    }

    /// <returns>
    /// True, if passed <param name="typeSymbol"/> represents <see cref="ImmutableArray{T}"/>.
    /// False otherwise
    /// </returns>
    public static bool IsImmutableArray(this ITypeSymbol? typeSymbol)
    {
        if (typeSymbol is null) return false;
        if (typeSymbol is not INamedTypeSymbol namedTypeSymbol) return false;

        return namedTypeSymbol.TypeKind == TypeKind.Struct
            && namedTypeSymbol.Arity == 1
            && namedTypeSymbol.Name == "ImmutableArray"
            && namedTypeSymbol.InNamespace("System.Collections.Immutable");
    }

    /// <returns>
    /// True, if passed <param name="typeSymbol"/> represents array. False otherwise
    /// </returns>
    /// <remarks>Checks it type is a zero-based one-dimensional array</remarks>
    public static bool IsArray(this ITypeSymbol? typeSymbol) => typeSymbol is IArrayTypeSymbol { IsSZArray: true };

    /// <returns>
    /// True, if passed <param name="typeSymbol"/> represents <see cref="List{T}"/>.
    /// False otherwise
    /// </returns>
    public static bool IsList(this ITypeSymbol? typeSymbol)
    {
        if (typeSymbol is null) return false;
        if (typeSymbol is not INamedTypeSymbol namedTypeSymbol) return false;

        return namedTypeSymbol.TypeKind == TypeKind.Class
            && namedTypeSymbol.Arity == 1
            && namedTypeSymbol.Name == "List"
            && namedTypeSymbol.InNamespace("System.Collections.Generic");
    }

    /// <returns>
    /// True, if passed <param name="typeSymbol"/> implements <see cref="IEnumerable{T}"/>. False otherwise
    /// </returns>
    /// <param name="searchedTypeSymbol">if found, an interface type symbol</param>
    /// <remarks>
    /// Most likely <see cref="IEnumerable{T}"/> is one of the last defined interfaces in a chain of implementations
    /// https://learn.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol.allinterfaces?view=roslyn-dotnet
    /// </remarks>
    public static bool ImplementsIEnumerable(this ITypeSymbol? typeSymbol, out ITypeSymbol? searchedTypeSymbol)
        => typeSymbol.ImplementsInterface(SpecialType.System_Collections_Generic_IEnumerable_T, out searchedTypeSymbol, searchFromStart: false);

    /// <returns>
    /// True, if passed <param name="typeSymbol"/> implements <see cref="IList{T}"/>. False otherwise
    /// </returns>
    /// <param name="searchedTypeSymbol">if found, an interface type symbol</param>
    public static bool ImplementsIList(this ITypeSymbol? typeSymbol, out ITypeSymbol? searchedTypeSymbol)
        => typeSymbol.ImplementsInterface(SpecialType.System_Collections_Generic_IList_T, out searchedTypeSymbol);


    /// <returns>
    /// True, if passed <param name="typeSymbol"/> implements <see cref="ICollection{T}"/>. False otherwise
    /// </returns>
    /// <param name="searchedTypeSymbol">if found, an interface type symbol</param>
    public static bool ImplementsICollection(this ITypeSymbol? typeSymbol, out ITypeSymbol? searchedTypeSymbol)
        => typeSymbol.ImplementsInterface(SpecialType.System_Collections_Generic_ICollection_T, out searchedTypeSymbol);

    /// <returns>
    /// True, if passed <param name="typeSymbol"/> implements <see cref="IReadOnlyCollection{T}"/>. False otherwise
    /// </returns>
    /// <param name="searchedTypeSymbol">if found, an interface type symbol</param>
    public static bool ImplementsIReadOnlyCollection(this ITypeSymbol? typeSymbol, out ITypeSymbol? searchedTypeSymbol)
        => typeSymbol.ImplementsInterface(SpecialType.System_Collections_Generic_IReadOnlyCollection_T, out searchedTypeSymbol);

    /// <returns>
    /// True, if passed <param name="typeSymbol"/> implements <see cref="IReadOnlyList{T}"/>. False otherwise
    /// </returns>
    /// <param name="searchedTypeSymbol">if found, an interface type symbol</param>
    public static bool ImplementsIReadOnlyList(this ITypeSymbol? typeSymbol, out ITypeSymbol? searchedTypeSymbol) 
        => typeSymbol.ImplementsInterface(SpecialType.System_Collections_Generic_IReadOnlyList_T, out searchedTypeSymbol);

    private static bool ImplementsInterface(
        this ITypeSymbol? typeSymbol,
        SpecialType interfaceType,
        out ITypeSymbol? searchedInterface,
        bool searchFromStart = true)
    {
        if (typeSymbol is null)
        {
            searchedInterface = null;
            return false;
        }

        if (searchFromStart)
        {
            for (var i = 0; i < typeSymbol.AllInterfaces.Length; i++)
            {
                var currentSymbol = typeSymbol.AllInterfaces[i];

                if (currentSymbol.SpecialType == interfaceType 
                    || currentSymbol.OriginalDefinition?.SpecialType == interfaceType)
                {
                    searchedInterface = currentSymbol;
                    return true;
                }
            }
        }
        else
        {
            for (var i = 0; i < typeSymbol.AllInterfaces.Length; i++)
            {
                var currentSymbol = typeSymbol.AllInterfaces[i];

                if (currentSymbol.SpecialType == interfaceType
                    || currentSymbol.OriginalDefinition?.SpecialType == interfaceType)
                {
                    searchedInterface = currentSymbol;
                    return true;
                }
            }
        }

        searchedInterface = null;
        return false;
    }
}