namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public virtual bool CanBeCancelledBy(User user)
        {
            return user.IsAdmin || MadeBy == user;
        }

    }

    public class HotelReservation : Reservation
    {
        public bool CanBeCancelledBy(User user)
        {
            return user.IsAdmin;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}