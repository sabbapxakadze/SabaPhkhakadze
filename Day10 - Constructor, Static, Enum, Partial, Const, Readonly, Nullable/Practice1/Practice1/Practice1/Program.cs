using Practice1;

Person[] people = new Person[3];

Home home1 = new Home();
home1.Address = "Agmashenebeli Street N12";
home1.City = "Tbilisi";

Home home2 = new Home();
home2.Address = "Rustaveli Street N89";
home2.City = "Tbilisi";

Home home3 = new Home();
home3.Address = "Bukhaidze Street N77";
home3.City = "Kutaisi";

people[0] = new Person("Saba", 19, "ID007");
people[0].Home = home1;

people[1] = new Person("Gari", 19, "ID008");
people[1].Home = home2;


people[2] = new Person("James", 23, "ID199");
people[2].Home = home3;


