using Serenity.Navigation;
using MyPages = SmartERP.RoomReservations.Pages;


[assembly: NavigationMenu(1920, "Room Reservations", icon: "fa-list-alt")]

[assembly: NavigationLink(int.MaxValue, "Room Reservations/Room Reservations", typeof(MyPages.RoomReservationsController), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Room Reservations/Room Reservation Details", typeof(MyPages.RoomReservationDetailsController), icon: null)]