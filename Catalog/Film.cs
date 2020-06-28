using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    class Film : Item
    {
        private string director, mainActor, mainActress;


        public Film(string director, string mainActor, string mainActress)
        {
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
        }

        public string GetDirector()
        {
            return director;
        }
        public void SetDirector(string director)
        {
            this.director = director;
        }
        public string GetMainActor()
        {
            return mainActor;
        }
        public void SetMainActor(string mainActor)
        {
            this.mainActor = mainActor;
        }
        public string GetMainActress()
        {
            return mainActress;
        }
        public void SetMainActress(string mainActress)
        {
            this.mainActress = mainActress;
        }
        public string Play()
        {
            return "";
        }
        public string RetrieveInformation()
        {
            return "";
        }
    }
}
