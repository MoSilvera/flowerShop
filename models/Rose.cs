namespace flower_shop {
    public class Rose: IBirthday {
        public string CommonName {get; set;}

    
        public bool Thorns {get; set;}

        public string Color {get; set;}

        public int PetalCount {get; set;}

    
        public override string ToString() {

            return "A beauitful rose"; 

        }
    }

}