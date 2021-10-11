using System;
using PracticaSemanaIV.Shared.Entity;
using System.Collections.Generic;

namespace PracticaSemanaIV.Client.Services
{
    public class ServicesMovie: IServiceMovie
    {
        public List<Movie>GetMovies(){
            return new List<Movie>(){

                new Movie(){Id=1, Name=" El Conjuro ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/conjuro.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=2, Name=" Deathsroke ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/deathstroke.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=3, Name=" Kimetsunoyaiba ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/kimetsunoyaiba.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=4, Name=" Monster hunter ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/monsterhunter.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=5, Name=" Paw patrol ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/pawpatrol.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=6, Name=" Ralph el demoledor ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/ralpheldemoledor.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=7, Name=" Raya y el ultimo dragon ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/rayayelultimodragon.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=8, Name=" Shang-chi ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/shang-chi.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=9, Name=" Spacejam ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/spacejam.jpg", Premier=new DateTime(2021,10,01)},
                new Movie(){Id=10, Name=" Venom ", Sipnosis="Trama de la movie ...", Poster="/Images/Movies/venom.jpg", Premier=new DateTime(2021,10,01)},
            };        

        }
        
    }
}