﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebShoes.Entity
{
    public class Products
    {

        [DisplayName("Id")]
        public int pd_Id { set; get; }


        [DisplayName("Product Name ")]
        public string pd_Name { set; get; }


        [DisplayName("Description")]
        public string pd_Description { set; get; }


        [DisplayName("Price Product")]
        public int pd_Price { set; get; }



        [DisplayName("ReducePrice")]
        public int pd_ReducePrice { set; get; }


        [DisplayName("Code Product")]
        public string pd_Code { set; get; }

        [DisplayName("NameImg1")]
        public string pd_NameImg1 { set; get; }

        [DisplayName("NameImg2")]
        public string pd_NameImg2 { set; get; }

        [DisplayName("NameImg3")]
        public string pd_NameImg3 { set; get; }

        [DisplayName("NameImg4")]
        public string pd_NameImg4 { set; get; }

        [DisplayName("Img1")]
        public string pd_Img1 { set; get; }

        [DisplayName("Img2")]
        public string pd_Img2 { set; get; }

        [DisplayName("Img3")]

        public string pd_Img3 { set; get; }

        [DisplayName("Img4")]
        public string pd_Img4 { set; get; }



        [DisplayName("Rate")]
        public int pd_Rate { set; get; }

        [DisplayName("MenuFacturer")]
        public string pd_MenuFacturer { set; get; }

        [DisplayName("ShortDescription")]
        public string pd_ShortDescription { set; get; }

        public string pd_Size { set; get; }
        public bool pd_Size7 { set; get; }
        public bool pd_Size7_5 { set; get; }
        public bool pd_Size8 { set; get; }
        public bool pd_Size8_5 { set; get; }
        public bool pd_Size9 { set; get; }
        public bool pd_Size9_5 { set; get; }
        public bool pd_Size10 { set; get; }
        public bool pd_Size10_5 { set; get; }
        public bool pd_Size11 { set; get; }
        public bool pd_Size11_5 { set; get; }
        public bool pd_Size12 { set; get; }
        public bool pd_Size12_5 { set; get; }
        public bool pd_Size13 { set; get; }
        public bool pd_Size13_5 { set; get; }
        public bool pd_Size14 { set; get; }
        public bool pd_Size14_5 { set; get; }


        [DisplayName("Brand")]
        public string pd_Brand { set; get; }

        [DisplayName("Style")]
        public string pd_Style { set; get; }

        [DisplayName("Color")]
        public string pd_Color { set; get; }

        [DisplayName("Material")]
        public string pd_Material { set; get; }

        [DisplayName("Technologies")]
        public string pd_Technologies { set; get; }

        public bool pd_WaitForConfirmation { set; get; }
        


        public List<ProductsInCategories> ProductsInCategoriesP { get; set; }
        public List<ProductInWishlist> ProductInWishlistP { get; set; }
        public List<ProductInCart> ProductInCartP { get; set; }
        public List<ReviewInproduct> ReviewInproductP { get; set; }

        public List<ProductInCartDevices> ProductInCartDevicesP { get; set; }

    }
}
