using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Avalonia.Controls;
using Avalonia.Interactivity;
using AvaloniaApplication2.Models;
using Azure.Messaging;

namespace AvaloniaApplication2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ShowUser();
    }

    private void ShowUser()
    {
        using (Gr601BokvaContext db = new Gr601BokvaContext())
        {
            var users = db.Clients.Join(db.Roles, c => c.RoleId, r => r.Id,
                (c, r) => new
                {
                    Name = c.Name,
                    Surname = c.Surname,
                    Lastname = c.Lastname,
                    Birthday = c.Birthday.ToString(),
                    Telephonenumber = c.Telephonenumber,
                    role_id = r.Rolename,
                    
                }).ToList();
            UserDataGrid.Items = users;
        }
    }

    
    /*private void DeleteUser()
    {
        using (Gr601BokvaContext db = new Gr601BokvaContext())
        {
            var selectedUser = UserDataGrid.SelectedItem as string;
            var user = db.Clients.Find(selectedUser);
            if (user != null)
            {
                db.Clients.Remove(user);
                db.SaveChanges();
            }
        }
    }*/

    private void DeleteUser_OnClick(object? sender, RoutedEventArgs e) 
    {
        using (Gr601BokvaContext db = new Gr601BokvaContext())
        {
            var slcUser = UserDataGrid.SelectedItem;
            var user = db.Clients.Find(slcUser);
            if (user != null)
            {
                db.Clients.Remove(user);
                db.SaveChanges();
            }
        }
        ShowUser();
    }

    private void AddUser_OnClick(object? sender, RoutedEventArgs e)
    {
        var wnd = new AddUser();
        wnd.Show();
    }
}