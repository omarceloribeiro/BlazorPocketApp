﻿using pocketbase_csharp_sdk.Models;
using pocketbase_csharp_sdk;
using ZXing;
using PocketBaseClient.BlazorPocket.Models;
using PocketBaseClient.BlazorPocket;

namespace BlazorPocket.Client.Services;

public static class PocketBaseExtensions
{

    public static User? GetCurrentUser(this BlazorPocketApplication pocketBaseClient)
    {
        if (pocketBaseClient.Auth.AuthStore.Model is not null && !string.IsNullOrWhiteSpace(pocketBaseClient.Auth.AuthStore.Model.Id))
        {
            return pocketBaseClient.Data.UsersCollection.GetById(pocketBaseClient.Auth.AuthStore.Model.Id);
        }
        return null;
        
    }

    public static Task<User?> GetCurrentUserAsync(this BlazorPocketApplication pocketBaseClient)
    {
        if (pocketBaseClient.Auth.AuthStore.Model is not null && !string.IsNullOrWhiteSpace(pocketBaseClient.Auth.AuthStore.Model.Id))
        {
            return pocketBaseClient.Data.UsersCollection.GetByIdAsync(pocketBaseClient.Auth.AuthStore.Model.Id);
        }

        return null;
    }
}