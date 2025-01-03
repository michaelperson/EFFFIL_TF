using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFFilm_1.Entites
{
    public class Movie
    {
        private int _id;
        private string _titre;
        private int _anneeDeSortie;
        private string _genre;
        private string _acteurPrincipal;
        private string _realisateur;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Titre
        {
            get
            {
                return _titre;
            }

            set
            {
                _titre = value;
            }
        }

        public int AnneeDeSortie
        {
            get
            {
                return _anneeDeSortie;
            }

            set
            {
                _anneeDeSortie = value;
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }

            set
            {
                _genre = value;
            }
        }

        public string ActeurPrincipal
        {
            get
            {
                return _acteurPrincipal;
            }

            set
            {
                _acteurPrincipal = value;
            }
        }

        public string Realisateur
        {
            get
            {
                return _realisateur;
            }

            set
            {
                _realisateur = value;
            }
        }
    }
}
