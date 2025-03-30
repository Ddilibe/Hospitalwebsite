using Serenity.Navigation;
using MyPages = SmartERP.RoomFacilities.Pages;

[assembly: NavigationMenu(1910, "Room Facilities", icon: "fa-list-alt")]

[assembly: NavigationLink(int.MaxValue, "Room Facilities/Room Sizes", typeof(MyPages.RoomSizesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Facilities/Room Facility Types", typeof(MyPages.RoomFacilityTypesController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Room Facilities/Room Facilities", typeof(MyPages.RoomFacilitiesController), icon: null)]