using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public void AddCategory(string text)
        {
            if (text.Any())
            {
                if (!this.Entities.Categories.Any(type => type.Label == text))
                {
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'une categorie", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        Category category = new Category();
                        category.Label = text;
                        this.Category.Add(category);

                        this.Entities.SaveChanges();
                        this.SelectedCategory = category;
                    }
                }
                else
                {
                    MessageBox.Show("La categorie existe déjà");
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un nom");
            }

        }

        /// <summary>
        /// Supprime la categorie selectionnée
        /// </summary>
        public void RemoveCategory()
        {
            //Vérification si on a le droit de supprimer

            if (SelectedCategory == null)
            {
                MessageBox.Show("Vous devez selectionner une categorie pour la supprimer");
            }
            else if (!SelectedCategory.Offers.Any())
            {
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion d'une categorie", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    // Suppression de l'élément
                    this.Entities.Categories.Remove(SelectedCategory);
                    this.Entities.SaveChanges();
                    this.Category.Remove(SelectedCategory);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lié a une categorie");
            }
        }

        #endregion

    }
}
