using System.Collections.Generic;

namespace flower_shop {
    public class Flowershop{
        public string ShopName {get; set;}

        public string OpeningTime {get; set;}

        public string ClosingTime {get; set;}

        public List <Rose> Roses {get; set;} = new List<Rose>();
        public List <Orchid> Orchids {get; set;} = new List<Orchid>();
        public List <Daisy> Daisy {get; set;} = new List<Daisy>();
        public List <Tulip> Tulip {get; set;} = new List<Tulip>();

        public List<IMothersDay> MakeMothersDayBouqet(){
            List<IMothersDay> arrangement = new List<IMothersDay>(){
                new Tulip() { Size = 2 },
                new Tulip() { Size = 2 },
                new Tulip() { Size = 2 },
                new Orchid() { Size = 3 },
                new Orchid() { Size = 3 },
            };

            return arrangement;
        }
public List<IBirthday> MakeBirthdayBouqet(){
            List<IBirthday> arrangement = new List<IBirthday>(){
               new Rose(),
               new Rose(),
               new Rose(),
               new Daisy(),
               new Daisy(),
            };

            return arrangement;
        }


    }


}