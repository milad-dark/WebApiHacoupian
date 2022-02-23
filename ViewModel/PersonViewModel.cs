namespace WebApiHacoupian.ViewModel
{
    public class PersonViewModel
    {
        public long PersonCode { get; set; }

        public class PersonWithSex
        {
            public bool sex { get; set; }
            public int take { get; set; }
        }

        public class PersonWithMarriageDate
        {
            public string date { get; set; }
            public int take { get; set; }
        }

        public class PersonWithCity
        {
            public int city { get; set; }
            public int take { get; set; }
        }

        public class PersonWithEmail
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }

        public class PersonRoleLogin
        {
            public int Id { get; set; }
            public string Role { get; set; }

        }

        public class CustomerAdd
        {
            public string name { get; set; }
            public string last_name { get; set; }
            public string mobile { get; set; }
            public string national_code { get; set; }
            public double birthdate { get; set; }
            public string email { get; set; }
            public bool sex { get; set; }
            public string cityName { get; set; }
            public string postalCode { get; set; }
            public string address { get; set; }
        }
        public class CustomerAddAddress
        {
            public long user_id { get; set; }
            public string cityName { get; set; }
            public string postalCode { get; set; }
            public string address { get; set; }
        }

        public class CustomerAddPhone
        {
            public long user_id { get; set; }
            public string mobile { get; set; }
        }

        public class CustomerPhone
        {
            public string mobile { get; set; }
        }

        public class CustomerAddView
        {
            public long user_id { get; set; }
            public long user_code { get; set; }
        }
    }
}
