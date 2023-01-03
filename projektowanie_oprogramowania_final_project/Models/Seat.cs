using System.ComponentModel.DataAnnotations;
using System;

namespace projektowanie_oprogramowania_final_project.Models
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [Required]
        public int Row { get; set; }

        [Required]
        public int SeatNumber { get; set; }

        /*  To chyba nie może być tutaj, albo będzie musiało inaczej działać.
            Przy takiej logice jeśli ktoś kupi bilet na siedzenie np 9
            w danej sali na wtorek 17.00, to dopóki seans nie przeminie, 
            to to siedzenie będzie 'occupied' i nie będzie można
            kupić biletu np na środę. Poza tym, jak jest C#, to czy te
            obiekty będą kopiowane? Czy referencja/pointer? Powiedzmy że
            działa to już inaczej, nieważne jak - jest kilka różnych rezerwacji
            na ten sam film - kiedy nowa rezerwacja bierze obiekt 'siedzenia', to ona
            będzie musiała się tego złapać po referencji, bo jeśli będzie po wartości
            to nowa rezerwacja nie będzie widziała że miejsce jest zajęte
            bo wewnątrz każdej rezerwacji będą nowe kopie obiektów siedzeń,
            zamiast referencji do jednego, tego samego obiektu z bazy danych. Mam wrażenie że
            się powtarzam, mam nadzieję że wypowiedź ma sens, ale nie wiem jak to
            będzie działało w C# do końca więc nie wiem co z tym zrobić.  */
        [Required]
        public bool Occupied { get; set; }
    }
}
