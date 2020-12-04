using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelCategory : ViewModelBase
    {
        #region Atributes

        /// <summary>
        /// Collection de Category
        /// </summary>
        private ObservableCollection<Category> _Category;

        /// <summary>
        /// Selectionne une cateogrie
        /// </summary>
        private Category _SelectedCategory;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou defini la category selectionné
        /// </summary>
        public Category SelectedCategory
        {
            get { return _SelectedCategory; }
            set { _SelectedCategory = value; }
        }

        /// <summary>
        /// Obtient ou defini la collection de category
        /// </summary>
        public ObservableCollection<Category> Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        #endregion


        #region Constructor

        public ViewModelCategory(Entities entities) : base(entities)
        {
            this.Entities.Categories.ToList();
            this.Category = this.Entities.Categories.Local;
        }

        #endregion

        #region Methods
        
        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }


        /// <summary>
        /// Ajoute une nouvelle categorie
        /// </summary>
        public void AddCategory()
        {
            if (!this.Entities.Categories
                .Any(type => type.Label == "Nom de la categorie")
                )
            {
                Category category = new Category();
                category.Label = "Nom";
                this.Category.Add(category);
                this.SaveChanges();
                this.SelectedCategory = category;
            }
        }

        /// <summary>
        /// Supprime la categorie selectionnée
        /// </summary>
        public void RemoveCategory()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.Category.Remove(SelectedCategory);
            this.SaveChanges();
        }

        #endregion

    }
}
