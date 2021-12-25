using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaWebsiteManager
{
    //public class Person
    //{   
    //    public string Name { get; set; } = "";
    //    public string Gender { get; set; } = "";
    //    public string Wanted { get; set; } = "";
    //    public string TwitterAccount { get; set; } = "";
    //    public string FacebookAccount { get; set; } = "";
    //    public string InstagramAccount{ get; set; } = "";
    //    public string From { get; set; } = "";
    //    public string Group { get; set; } = "";
    //    public int MoralRank { get; set; } = 0;
    //    public string Description { get; set; } = "";
    //    public string BestowDate { get; set; } = "";

    //    public static implicit operator NewPerson(Person p)
    //    {
    //        return new NewPerson
    //        {                
    //            ID = Guid.NewGuid().ToString(),
    //            Name = p.Name,
    //            Gender = p.Gender,
    //            Wanted = p.Wanted,
    //            TwitterAccount = p.TwitterAccount,
    //            FacebookAccount = p.FacebookAccount,
    //            InstagramAccount = p.InstagramAccount,
    //            From = p.From,
    //            Group = p.Group,
    //            MoralRank = p.MoralRank,
    //            Description = p.Description,
    //            LastBestowDate = p.BestowDate,
    //        };
    //    }
    //}

    public class Person
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Surname { get; set; } = "";        
        public string Name { get; set; } = "";
        public string OtherName { get; set; } = "";
        public string SurnameFirst { get; set; } = "y";
        public string Yomikata { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Fiction { get; set; } = "n";
        public string Wanted { get; set; } = "n";
        public string Protected { get; set; } = "n";
        public string TwitterAccount { get; set; } = "";
        public string FacebookAccount { get; set; } = "";
        public string InstagramAccount { get; set; } = "";
        public string From { get; set; } = "";
        public string Group { get; set; } = "i";
        public string IsAOMember { get; set; } = "n";
        public string IsCelebrity { get; set; } = "y";
        public int MoralRank { get; set; } = 0;
        public string Description { get; set; } = "";
        public string LastBestowDate { get; set; } = "";
        public string PicturePath { get; set; } = "";

        //public int CompareTo(Person other)
        //{
        //    if (other == null)
        //        return -1;
        //    if (other.MoralRank > MoralRank) return 1;
        //    if (other.Gender == "m") return 1;
        //    if (other.Name.CompareTo(Name) > 0) return 1;
        //    return -1;
        //}
    }   
}
