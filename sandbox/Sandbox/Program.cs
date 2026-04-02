using System;

class Program
{
    static void Main(string[] args)
    {
        Prayer ourFather = new ("Our Father in heaven, may your name be revered as holy. May your kingdom come. May your will be done on earth as it is in heaven. Give us today our daily bread. And forgive us our debts, as we also have forgiven our debtors. And do not bring us to the time of trial, but rescue us from the evil one.");
        Prayer hailMary = new ("Hail Mary, full of grace, the Lord is with thee. Blessed art thou amongst women, and blessed is the fruit of thy womb, Jesus. Holy Mary, Mother of God, pray for us sinners, now and at the hour of our death. Amen.");
        

        
        Prayer joyfulAnnununciation = new ("In the sixth month the angel Gabriel was sent from God to a city of Galilee named Nazareth, to a virgin betrothed to a man whose name was Joseph, of the house of David; and the virgin's name was Mary.");
        Prayer joyfulVisitation = new ("In those days Mary arose and went with haste into the hill country, to a city of Judah, and she entered the house of Zechariah and greeted Elizabeth. And when Elizabeth heard the greeting of Mary, the babe leaped in her womb; and Elizabeth was filled with the Holy Spirit and she exclaimed with a loud cry, 'Blessed are you among women, and blessed is the fruit of your womb!");
        Prayer joyfulNativity = new ("In those days a decree went out from Caesar Augustus that all the world should be enrolled. This was the first enrolment, when Quirinius was governor of Syria. And all went to be enrolled, each to his own city. And Joseph also went up from Galilee, from the city of Nazareth, to Judea, to the city of David, which is called Bethlehem, because he was of the house and lineage of David, to be enrolled with Mary, his betrothed, who was with child. And while they were there, the time came for her to be delivered. And she gave birth to her first-born son and wrapped him in swaddling cloths, and laid him in a manger, because there was no place for them in the inn"); 
        Prayer joyfulPresentation = new ("And at the end of eight days, when he was circumcised, he was called Jesus, the name given by the angel before he was conceived in the womb. And when the time came for their purification according to the law of Moses, they brought him up to Jerusalem to present him to the Lord (as it is written in the law of the Lord, 'Every male that opens the womb shall be called holy to the Lord') and to offer a sacrifice according to what is said in the law of the Lord, 'a pair of turtledoves, or two young pigeons");
        Prayer joyfulFinding = new ("Now his parents went to Jerusalem every year at the feast of the Passover. And when he was twelve years old, they went up according to custom; and when the feast was ended, as they were returning, the boy Jesus stayed behind in Jerusalem. His parents did not know it ... After three days they found him in the temple, sitting among the teachers, listening to them and asking them questions; and all who heard him were amazed at his understanding and his answers");

        Rosary JoyfulMysteries = new ();
        JoyfulMysteries.AddDecade(new Decade(joyfulAnnununciation, hailMary));
        JoyfulMysteries.AddDecade(new Decade(joyfulVisitation, hailMary));
        JoyfulMysteries.AddDecade(new Decade(joyfulNativity, hailMary));
        JoyfulMysteries.AddDecade(new Decade(joyfulPresentation, hailMary));
        JoyfulMysteries.AddDecade(new Decade(joyfulFinding, hailMary));

        JoyfulMysteries.Pray();
    }
}