namespace InterfaceDemo
{
    // Eğer sonradan gamer haricinde admin gibi farklı türden kullanıcı eklemek istersek bu sınıf sayesinde
    // oyun bilgileri olmadan sadece kimlik bilgileri ile kolayca ekleyebiliriz. Eğer farklı bilgilere de
    // ihtiyaç olursa Gamer sınıfı gibi bir sınıf daha oluşturabiliriz.
    class User
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
    }
}
