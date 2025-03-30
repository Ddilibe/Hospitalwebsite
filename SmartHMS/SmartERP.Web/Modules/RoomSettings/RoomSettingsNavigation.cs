using Serenity.Navigation;
using MyPages = SmartERP.RoomSettings.Pages;

[assembly: NavigationMenu(1930, "Room Settings", icon: "fa-list-alt")]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Rooms", typeof(MyPages.RoomsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Room Types", typeof(MyPages.RoomTypesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Booking Types", typeof(MyPages.BookingTypesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Booking Soruces", typeof(MyPages.BookingSorucesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Bed Types", typeof(MyPages.BedTypesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Floors", typeof(MyPages.FloorsController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Floor Plans", typeof(MyPages.FloorPlansController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Room Images", typeof(MyPages.RoomImagesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Settings/Complementaries", typeof(MyPages.ComplementariesController), icon: null)]