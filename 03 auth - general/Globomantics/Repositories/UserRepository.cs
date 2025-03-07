﻿using Globomantics.Models;

namespace Globomantics.Repositories;

public class UserRepository : IUserRepository
{
    private List<UserModel> users = new () 
    {
        //new UserModel { Id = 3522, Name = "roland", Password = "K7gNU3sdo+OL0wNhqoVWhr3g6s1xYv72ol/pe/Unols=",
        //    FavoriteColor = "blue", Role = "Admin", GoogleId = "101517359495305583936" }
        new UserModel { Id = 123, Name = "test", Password = "XohImNooBHFR0OVvjcYpJ3NgPQ1qq73WKhHvch0VQtg=", Role = "Admin", GoogleId = "101019733588613984575", FavoriteColor = "green" }
    };

    public UserModel? GetByUsernameAndPassword(string username, string password)
    {
        var user = users.SingleOrDefault(
            u => u.Name == username && u.Password == password.Sha256());
        return user;
    }

    public UserModel? GetByGoogleId(string googleId)
    {
        var user = users.SingleOrDefault(
            u => u.GoogleId == googleId);
        return user;
    }
}