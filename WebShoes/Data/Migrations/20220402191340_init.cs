﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShoes.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "UserRoles",
                newName: "IX_UserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "UserLogins",
                newName: "IX_UserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "UserClaims",
                newName: "IX_UserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "RoleClaims",
                newName: "IX_RoleClaims_RoleId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DoB",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bill_Address1",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bill_Address2",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bill_City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bill_CompanyName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bill_Country",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bill_PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bill_PostalCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bill_State",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    about_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    about_Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    about_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.about_id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    bill_PaidTotal = table.Column<int>(type: "int", nullable: false),
                    bill_ProductIdlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductNamelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductSizelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductColorlist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_ProductPricelist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Shipping = table.Column<int>(type: "int", nullable: false),
                    bill_Discount = table.Column<int>(type: "int", nullable: false),
                    bill_Confirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_DatetimeOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bill_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false),
                    bill_WaitPickup = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivering = table.Column<bool>(type: "bit", nullable: false),
                    bill_Delivered = table.Column<bool>(type: "bit", nullable: false),
                    bill_Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_Users_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    cart_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cart_UserID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cart_Discount = table.Column<int>(type: "int", nullable: false),
                    cart_Coupon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.cart_Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_cart_UserID",
                        column: x => x.cart_UserID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cg_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cg_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cg_Sale = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cg_Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesHome",
                columns: table => new
                {
                    CategoriesHomeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoriesHomeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHomeUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHomeUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHomeUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHomeUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHomeUrl5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHomeUrl6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHomeUrl7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoriesHomeUrl8 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesHome", x => x.CategoriesHomeId);
                });

            migrationBuilder.CreateTable(
                name: "ContactSystems",
                columns: table => new
                {
                    Contact_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact_Youtube = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSystems", x => x.Contact_Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsers",
                columns: table => new
                {
                    cu_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cu_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cu_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsers", x => x.cu_Id);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    couponId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    couponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    couponPrice = table.Column<int>(type: "int", nullable: false),
                    couponAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.couponId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerHome",
                columns: table => new
                {
                    CustomerHomeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CustomerHomeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerHome_CImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerHome_CName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerHome_CWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerHome_CStar = table.Column<int>(type: "int", nullable: false),
                    CustomerHome_CDesription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerHome", x => x.CustomerHomeId);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    deviceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    deviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    devicePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deviceAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.deviceId);
                });

            migrationBuilder.CreateTable(
                name: "FeatureHome",
                columns: table => new
                {
                    FeatureHomeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FeatureHomeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureHomeTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureHomeDesription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureHomeTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureHomeDesription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureHomeTitle3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureHomeDesription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureHomeTitle4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureHomeDesription4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureHome", x => x.FeatureHomeId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pd_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pd_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Price = table.Column<int>(type: "int", nullable: false),
                    pd_ReducePrice = table.Column<int>(type: "int", nullable: false),
                    pd_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_NameImg4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Img4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Rate = table.Column<int>(type: "int", nullable: false),
                    pd_MenuFacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Size7 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size7_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size8 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size8_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size9 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size9_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size10 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size10_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size11 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size11_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size12 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size12_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size13 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size13_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size14 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Size14_5 = table.Column<bool>(type: "bit", nullable: false),
                    pd_Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_Technologies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pd_WaitForConfirmation = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pd_Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    review_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    review_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    review_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    review_ReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    review_UploadTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.review_id);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_review_UserId",
                        column: x => x.review_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    ship_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ship_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.ship_Id);
                });

            migrationBuilder.CreateTable(
                name: "SliderHome",
                columns: table => new
                {
                    SliderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SliderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SliderUrl5 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderHome", x => x.SliderId);
                });

            migrationBuilder.CreateTable(
                name: "SubReview",
                columns: table => new
                {
                    subReview_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    subReview_Commnet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    subReview_HideStatus = table.Column<bool>(type: "bit", nullable: false),
                    subreview_SubReviewType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subReview_DateCommnet = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReview", x => x.subReview_Id);
                    table.ForeignKey(
                        name: "FK_SubReview_Users_subReview_UserId",
                        column: x => x.subReview_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subsriber",
                columns: table => new
                {
                    Subs_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Subs_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subs_TimeUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subsriber", x => x.Subs_Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInRoleModel",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameRole = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInRoleModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    wl_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    wl_UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.wl_Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_Users_wl_UserId",
                        column: x => x.wl_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartsDevice",
                columns: table => new
                {
                    cartd_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cartd_DeviceId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cartd_Discount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartsDevice", x => x.cartd_Id);
                    table.ForeignKey(
                        name: "FK_CartsDevice_Device_cartd_DeviceId",
                        column: x => x.cartd_DeviceId,
                        principalTable: "Device",
                        principalColumn: "deviceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCart",
                columns: table => new
                {
                    pic_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pic_ProductId = table.Column<int>(type: "int", nullable: false),
                    pic_amount = table.Column<int>(type: "int", nullable: false),
                    pic_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pic_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCart", x => new { x.pic_CartId, x.pic_ProductId, x.pic_Id });
                    table.ForeignKey(
                        name: "FK_ProductInCart_Carts_pic_CartId",
                        column: x => x.pic_CartId,
                        principalTable: "Carts",
                        principalColumn: "cart_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCart_Products_pic_ProductId",
                        column: x => x.pic_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInCategories",
                columns: table => new
                {
                    pic_CategoriesId = table.Column<int>(type: "int", nullable: false),
                    pic_productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInCategories", x => new { x.pic_productId, x.pic_CategoriesId });
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Categories_pic_CategoriesId",
                        column: x => x.pic_CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "cg_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductsInCategories_Products_pic_productId",
                        column: x => x.pic_productId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReviewInproduct",
                columns: table => new
                {
                    rip_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    rip_ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewInproduct", x => new { x.rip_ProductId, x.rip_ReviewId });
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Products_rip_ProductId",
                        column: x => x.rip_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReviewInproduct_Reviews_rip_ReviewId",
                        column: x => x.rip_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubReviewInReview",
                columns: table => new
                {
                    SRiR_ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SRiR_SubReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubReviewInReview", x => new { x.SRiR_ReviewId, x.SRiR_SubReviewId });
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_Reviews_SRiR_ReviewId",
                        column: x => x.SRiR_ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "review_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubReviewInReview_SubReview_SRiR_SubReviewId",
                        column: x => x.SRiR_SubReviewId,
                        principalTable: "SubReview",
                        principalColumn: "subReview_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInWishlist",
                columns: table => new
                {
                    piw_WishlistId = table.Column<int>(type: "int", nullable: false),
                    piw_ProductId = table.Column<int>(type: "int", nullable: false),
                    piw_amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInWishlist", x => new { x.piw_WishlistId, x.piw_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInWishlist_Products_piw_ProductId",
                        column: x => x.piw_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInWishlist_Wishlists_piw_WishlistId",
                        column: x => x.piw_WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "wl_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInCartDevices",
                columns: table => new
                {
                    picd_CartId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    picd_ProductId = table.Column<int>(type: "int", nullable: false),
                    picd_amount = table.Column<int>(type: "int", nullable: false),
                    picd_size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picd_color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInCartDevices", x => new { x.picd_CartId, x.picd_ProductId });
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_CartsDevice_picd_CartId",
                        column: x => x.picd_CartId,
                        principalTable: "CartsDevice",
                        principalColumn: "cartd_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInCartDevices_Products_picd_ProductId",
                        column: x => x.picd_ProductId,
                        principalTable: "Products",
                        principalColumn: "pd_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "about_id", "about_Description", "about_Title", "about_Url" },
                values: new object[] { 1, "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way.", "Footwear the leading eCommerce Store around the Globe", "https://www.youtube.com/watch?v=F1vcruph8JA" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "cg_Id", "cg_Name", "cg_Sale", "cg_Type" },
                values: new object[,]
                {
                    { 1, "women", "", "" },
                    { 2, "Man", "", "" },
                    { 3, "BestSeller", "", "" },
                    { 4, "TopSeller", "", "" },
                    { 5, "Hangbag", "", "" }
                });

            migrationBuilder.InsertData(
                table: "CategoriesHome",
                columns: new[] { "CategoriesHomeId", "CategoriesHomeName", "CategoriesHomeUrl1", "CategoriesHomeUrl2", "CategoriesHomeUrl3", "CategoriesHomeUrl4", "CategoriesHomeUrl5", "CategoriesHomeUrl6", "CategoriesHomeUrl7", "CategoriesHomeUrl8" },
                values: new object[] { "ad7731c2-1773-4cc5-9797-0235fbf8b8e0", "CategoriesHome1", "https://drive.google.com/uc?export=download&id=1VYldlvs2ROaTJPsE2eIkMXktOBbLHy9f", "https://drive.google.com/uc?export=download&id=1j0uME7aL_KXY1df6AN0p8psngFdiX73K", "https://drive.google.com/uc?export=download&id=1Gm-TZ2nqI5eUAU0O45cgeay38AS0OxiI", "https://drive.google.com/uc?export=download&id=1g4QK9WF2e9aXHpJCUXK0-1H6j6kC7r5L", "https://drive.google.com/uc?export=download&id=14ybZRAMDRY_OhMcCXXzVtjeyHhnaKn5l", "https://drive.google.com/uc?export=download&id=1vOIH3t8uhGxNKF7w76kViqlmlQH1-6YU", "https://drive.google.com/uc?export=download&id=18tu3dYEqUmKx5bJL_hjSN467GO3cbaQE", "https://drive.google.com/uc?export=download&id=1EEMOiZF6E5sKIFGntEySd0SVvZmvFe78" });

            migrationBuilder.InsertData(
                table: "ContactSystems",
                columns: new[] { "Contact_Id", "Contact_Address", "Contact_Email", "Contact_Facebook", "Contact_Instagram", "Contact_Linkedin", "Contact_Phone", "Contact_Twitter", "Contact_Website", "Contact_Youtube" },
                values: new object[] { 1, " 123, An Lac A Ward, Binh Tan District, HCM", "admin@gmail.com", null, null, null, "0123456789", null, "https://shoes.com", null });

            migrationBuilder.InsertData(
                table: "ContactUsers",
                columns: new[] { "cu_Id", "cu_Description", "cu_Email", "cu_FirstName", "cu_LastName", "cu_Subject" },
                values: new object[] { 1, "Description", "Email", "FirstName", "LastName", "Subject" });

            migrationBuilder.InsertData(
                table: "Coupons",
                columns: new[] { "couponId", "couponAmount", "couponCode", "couponPrice" },
                values: new object[,]
                {
                    { "442b9ced-2115-43ce-841a-d6861de590cd", 25, "code50", 50 },
                    { "297857ae-440e-4d32-84e8-01146547198b", 20, "code10", 10 }
                });

            migrationBuilder.InsertData(
                table: "CustomerHome",
                columns: new[] { "CustomerHomeId", "CustomerHomeName", "CustomerHome_CDesription", "CustomerHome_CImg", "CustomerHome_CName", "CustomerHome_CStar", "CustomerHome_CWork" },
                values: new object[,]
                {
                    { "fc318190-07ae-437e-95e2-90fb4b52b214", "FeatureHome3", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vitae nunc eget leo finibus luctus et vitae lorem", "https://drive.google.com/uc?export=download&id=1-VztC3V4O7HyIdetuemHMO61M5up94uD", "Customer 3", 5, "Profession" },
                    { "d9ba3cd8-2d49-484e-961f-de3a13b893c4", "FeatureHome2", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vitae nunc eget leo finibus luctus et vitae lorem", "https://drive.google.com/uc?export=download&id=12xlH3LvPKtXEUTRFdETM7SGvCnjU9S-c", "Customer 2", 5, "Profession" },
                    { "4138f605-e350-42ec-a9f9-0aee7f813de1", "FeatureHome1", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur vitae nunc eget leo finibus luctus et vitae lorem", "https://drive.google.com/uc?export=download&id=12BEbKPhMNT6Gl31Wgzo1XNA6kf5zCtYm", "Customer 1", 5, "Profession" }
                });

            migrationBuilder.InsertData(
                table: "FeatureHome",
                columns: new[] { "FeatureHomeId", "FeatureHomeDesription1", "FeatureHomeDesription2", "FeatureHomeDesription3", "FeatureHomeDesription4", "FeatureHomeName", "FeatureHomeTitle1", "FeatureHomeTitle2", "FeatureHomeTitle3", "FeatureHomeTitle4" },
                values: new object[] { "a8dfa0e8-751e-4ff2-81bd-379e40c38f0b", "Lorem ipsum dolor sit amet consectetur elit", "Lorem ipsum dolor sit amet consectetur elit", "Lorem ipsum dolor sit amet consectetur elit", "Lorem ipsum dolor sit amet consectetur elit", "FeatureHome1", "Secure Payment", "Worldwide Delivery", "90 Days Return", "24/7 Support" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Brand", "pd_Code", "pd_Color", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Material", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size", "pd_Size10", "pd_Size10_5", "pd_Size11", "pd_Size11_5", "pd_Size12", "pd_Size12_5", "pd_Size13", "pd_Size13_5", "pd_Size14", "pd_Size14_5", "pd_Size7", "pd_Size7_5", "pd_Size8", "pd_Size8_5", "pd_Size9", "pd_Size9_5", "pd_Style", "pd_Technologies", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { 28, "ADLV", "PD028", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "./img/Product28-black.png", "./img/Product28-gray.png", "./img/Product28-purple.png", "", "1", "1", "ADLV RAINBOW CLOUD LOGO SHORT SLEEVE T-SHIRT BLACK", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 17, "Moschino", "PD017", "", "", "./img/Product17-black.jpg", "./img/Product17-blue.jpg", "./img/Product17-gray.jpg", "", "1", "1", "MOSCHINO TEE WARRIOR", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 18, "Moschino", "PD018", "", "", "./img/Product18-gray.jpg", "./img/Product18-pink.jpg", "./img/Product18-white.jpg", "", "1", "1", "MOSCHINO TEE DOLLARS", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 19, "Moschino", "PD019", "White", "", "./img/Product19-blue.jpg", "./img/Product19-red.jpg", "./img/Product19-yellow.jpg", "", "1", "1", "MOSCHINO T-SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 20, "Moschino", "PD020", "White", "", "./img/Product20-black.jpg", "./img/Product20-pink.jpg", "./img/Product20-white.jpg", "", "1", "1", "MOSCHINO T-SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 21, "Moschino", "PD021", "Black", "", "./img/Product21-blue.png", "./img/Product21-cream.png", "./img/Product21-gray.png", "", "1", "1", "MOSCHINO T-SHIRT COUTURE", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 22, "Supreme", "PD022", "White", "", "./img/Product22-blue.png", "./img/Product22-gray.png", "./img/Product22-green.png", "", "1", "1", "SUPREME SPIRAL T-SHIRT - WHITE", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 23, "Supreme", "PD023", "Black", "", "./img/Product23-black.png", "./img/Product23-blue.png", "./img/Product23-redjpg.png", "", "1", "1", "SUPREME SPIRAL T-SHIRT - BLACK", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 24, "eteft", "PD024", "", "", "./img/Product24-black.png", "./img/Product24-blue.png", "./img/Product24-brown.png", "", "1", "1", "SUPREME CROSS BOX LOGO T-SHIRT - NAVY", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 25, "ADLV", "PD025", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "./img/Product25-black.png", "./img/Product25-blue.png", "./img/Product25-cream.png", "", "1", "1", "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK DONUTS 1", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 26, "ADLV", "PD026", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "./img/Product26-black.png", "./img/Product26-blue.png", "./img/Product26-cream.png", "", "1", "1", "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK ASTRONAUT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 30, "ADLV", "PD030", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "./img/Product30-black.png", "./img/Product30-brown.png", "./img/Product30-brown.png", "", "1", "1", "ADLV BABY FACE SHORT SLEEVE T-SHIRT BLACK RABBIT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 29, "ADLV", "PD029", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "./img/Product29-blue.png", "./img/Product29-gray.png", "./img/Product29-green.png", "", "1", "1", "ADLV TEDDY BEAR SHORT SLEEVE T-SHIRT BLACK", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 16, "Moschino", "PD016", "Black", "", "./img/Product16-black.jpg", "./img/Product16-red.jpg", "./img/Product16-white.jpg", "", "1", "1", "MOSCHINO T-SHIRT GOLD LOGO WITH PIG", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "T-shirt", "1", false },
                    { 27, "ADLV", "PD027", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "./img/Product27-black.png", "./img/Product27-gray.png", "./img/Product27-purple.png", "", "1", "1", "ADLV ASTRONAUT TRIO SHORT SLEEVE T-SHIRT - BLACK", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 15, "eteft", "PD015", "", "", "./img/Product15-gray.jpg", "./img/Product15-green.jpg", "./img/Product15-yellow.jpg", "", "1", "1", "GUCCI GG STRETCH COTTON POLO - DARK GREEN", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 6, "ADLV", "PD006", "", "First born in 2017, ACMÉ DE LA VIE (ADLV) with market understanding and modern designs, in line with the common tastes of urban citizens, has quickly become one of Korea's leading local streetwear brands today.", "./img/Product6-black.jpg", "./img/Product6-gray.jpg", "./img/Product6-white.jpg", "", "1", "1", "ADLV SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 13, "eteft", "PD013", "", "", "./img/Product13-dark-blue.jpg", "./img/Product13-green.jpg", "./img/Product13-pink.jpg", "", "1", "1", "BURBERRY SHIRT LIGHT BROWN", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 1, "Off White", "PD001", "Black", "black / purple / red ,cotton, signature arrow pattern, logo print on chest, round neck, short sleeves, straight border", "./img/Product1-blue.png", "./img/Product1-brown.png", "./img/Product1-white.png", "", "1", "1", "OFF-WHITE ARROWS PRINT COTTON SLIM T-SHIRT - BLACK/PURPLE/RED", "1", "2", "3", "4", 80, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 2, "Off White", "PD002", "Black", "", "./img/Product2-black.jpg", "./img/Product2-gray.jpg", "./img/Product2-purple.jpg", "", "1", "1", "OFF-WHITE ARROWS PRINT SHORT-SLEEVE T-SHIRT - BLACK/GREY SS21", "1", "2", "3", "4", 50, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 3, "Off White", "PD003", "White/Blue", "White, cotton, signature arrow pattern, logo print on chest, round neck, short sleeves, straight border", "./img/Product3-black.jpg", "./img/Product3-blue.jpg", "./img/Product3-white.jpg", "", "1", "1", "OFF-WHITE ARROWS PRINT SHORT-SLEEVE T-SHIRT - WHITE/BLUE SS21", "1", "2", "3", "4", 40, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 14, "Thom Browne", "PD014", "White", "Endless styling opportunities are in store with this Thom Browne shirt. Made from breathable cotton, this piece is both cool and comfortable. Talk about no trouble. Features a button-down collar, front button closure, open front pockets, curved hemline, front logo patch and tricolor stripe detail with buttons on both sleeves", "./img/Product14-black.jpg", "./img/Product14-white.jpg", "./img/Product14-yellow.jpg", "", "1", "1", "THOM BROWNE WHITE SHORT SLEEVE SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 5, "Burberry", "PD005", "", "- The shirt is made of breathable cotton fabric, good sweat absorption, bringing comfort to the wearer. Beautiful standard shirt form, delicate seams meticulous detail to satisfy even fastidious customers.", "./img/Product5-black.jpg", "./img/Product5-blue.jpg", "./img/Product5-yellow.jpg", "", "1", "1", "BURBERRY SHIRT", "1", "2", "3", "4", 99, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 4, "Andrea Martin", "PD004", "Gray", "", "./img/Product4-blue.jpg", "./img/Product4-cream.jpg", "./img/Product4-white.jpg", "", "1", "1", "ANDREA MARTIN Grey Astronaut Mesh Shirt", "1", "2", "3", "4", 90, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Slim 3-layer mesh top", "1", false },
                    { 7, "Burberry", "PD007", "", "", "./img/Product7-blue.png", "./img/Product7-white.png", "./img/Product7-yellow.png", "", "1", "1", "BURBERRY SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 8, "eteft", "PD008", "", "", "./img/Product8-pink.jpg", "./img/Product8-white.jpg", "./img/Product8-yellow.jpg", "", "1", "1", "BURBERRY MONOGRAM MOTIF STRETCH COTTON POPLIN SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false },
                    { 9, "Thom Browne", "PD009", "White", "", "./img/Product9-black.png", "./img/Product9-blue.png", "./img/Product9-red.png", "", "1", "1", "THOM BROWN SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "pd_Id", "pd_Brand", "pd_Code", "pd_Color", "pd_Description", "pd_Img1", "pd_Img2", "pd_Img3", "pd_Img4", "pd_Material", "pd_MenuFacturer", "pd_Name", "pd_NameImg1", "pd_NameImg2", "pd_NameImg3", "pd_NameImg4", "pd_Price", "pd_Rate", "pd_ReducePrice", "pd_ShortDescription", "pd_Size", "pd_Size10", "pd_Size10_5", "pd_Size11", "pd_Size11_5", "pd_Size12", "pd_Size12_5", "pd_Size13", "pd_Size13_5", "pd_Size14", "pd_Size14_5", "pd_Size7", "pd_Size7_5", "pd_Size8", "pd_Size8_5", "pd_Size9", "pd_Size9_5", "pd_Style", "pd_Technologies", "pd_WaitForConfirmation" },
                values: new object[,]
                {
                    { 10, "Burberry", "PD010", "", "", "./img/Product10-blue.png", "./img/Product10-pink.jpg", "./img/Product10-white.jpg", "", "1", "1", "BURBERRY SHIRT", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "Shirt", "1", false },
                    { 12, "eteft", "PD012", "", "", "./img/Product12-black.jpg", "./img/Product12-red.jpg", "./img/Product12-yellow.jpg", "", "1", "1", "BURBERRY SHIRT LIGHT BROWN", "1", "2", "3", "4", 100, 5, 10, "", "", true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, "", "1", false }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "a0c1b3b5-0647-41ba-b317-6d2f30a9c674", "Admin", "AppRole", "Admin", "ADMIN" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "81ca6b68-fd88-4dec-aa44-3213aa109968", "Staff", "AppRole", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "Shipping",
                columns: new[] { "ship_Id", "ship_Name", "ship_Price" },
                values: new object[] { "7CF94A7D-9239-446E-A404-086518F84652", "Ship", 1 });

            migrationBuilder.InsertData(
                table: "SliderHome",
                columns: new[] { "SliderId", "SliderName", "SliderUrl1", "SliderUrl2", "SliderUrl3", "SliderUrl4", "SliderUrl5" },
                values: new object[] { "27078067-fc0d-4700-8a79-8e8407411f06", "SliderHome1", "https://drive.google.com/uc?export=download&id=1z9XgREv00FGoCR7zke-NzoNnIBiQYqvM", "https://drive.google.com/uc?export=download&id=15xcKBMdxJeQMTLaQjHh9KbT6ZlKGsaZv", "https://drive.google.com/uc?export=download&id=1q3-Sg09LDSshwDBe3WVOTlcx0QmP-0tT", "", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "bill_Address1", "bill_Address2", "bill_City", "bill_CompanyName", "bill_Country", "bill_PhoneNumber", "bill_PostalCode", "bill_State" },
                values: new object[,]
                {
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", 0, "9456ad97-acf2-4959-af0a-12db5af84912", "AppUser", new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@gmail.com", true, "staff", "staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAELr/CoaD1xkv04AWdcPvLzl4b6GLDPU1nDOR+JYeB7txajZFx86yjU0Gl/TrwxaSTw==", null, false, "fe34e480-4de2-4d3c-8afd-d2143f890624", false, "Staff", null, null, null, null, null, null, null, null },
                    { "DE544998-A3CC-4E12-ABB4-0642E57BD222", 0, "6386d690-9238-4c4a-bfee-c096fa48e734", "AppUser", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "admin", "admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEF77WGYdFQMuPX+bdwCtGbtIQvtl/3hjKb8M00C29QX52y+9q3YCmEAjKkTe7SegMw==", null, false, "4ed879c9-1757-4580-ac81-bb1d5285e5eb", false, "Admin", "HCM 1", "HCM 2", "HCM", "0123456789", "Viet Nam", "0112223344", "700000", "700000" }
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancelled", "bill_Confirmation", "bill_DatetimeOrder", "bill_Delivered", "bill_Delivering", "bill_Discount", "bill_HideStatus", "bill_Note", "bill_PaidTotal", "bill_PaymentMethod", "bill_ProductColorlist", "bill_ProductIdlist", "bill_ProductNamelist", "bill_ProductPricelist", "bill_ProductSizelist", "bill_Quantity", "bill_Shipping", "bill_UserId", "bill_WaitForConfirmation", "bill_WaitPickup" },
                values: new object[,]
                {
                    { "D269BF93-A5E2-4C4A-8146-9967DDE80D30", false, true, new DateTime(2022, 4, 3, 2, 13, 39, 406, DateTimeKind.Local).AddTicks(3538), false, false, 0, false, "", 2000, "Check Payment", "Blue|Red|Black|Green", "1|2|3|4", "product 1|product 2| product 3| product 4", "550|450|350|640", "7|8|9|14", "1|1|2|1", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false },
                    { "AFD66490-12F5-4EA7-BFF6-425624290D6D", false, true, new DateTime(2022, 4, 3, 2, 13, 39, 408, DateTimeKind.Local).AddTicks(231), false, false, 0, false, "", 2100, "Check Payment", "Blue|Red|Black|Green", "5|6|7|8", "product 5|product 6| product 7| product 8", "550|450|350|640", "7|8|9|14", "1|1|2|2", 10, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", false, false }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "cart_Id", "cart_Coupon", "cart_Discount", "cart_UserID" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", 0, 0, "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "72309286-ECBB-4D20-AD95-2819D31E3400", 0, 0, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "ProductsInCategories",
                columns: new[] { "pic_CategoriesId", "pic_productId" },
                values: new object[,]
                {
                    { 2, 8 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 5, 23 },
                    { 5, 22 },
                    { 1, 13 },
                    { 5, 24 },
                    { 5, 25 },
                    { 5, 26 },
                    { 5, 27 },
                    { 5, 28 },
                    { 5, 21 },
                    { 1, 12 },
                    { 5, 30 },
                    { 2, 9 },
                    { 5, 29 },
                    { 2, 7 },
                    { 2, 6 },
                    { 2, 5 },
                    { 2, 4 },
                    { 2, 3 },
                    { 2, 2 },
                    { 2, 1 },
                    { 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "review_id", "review_Comment", "review_HideStatus", "review_ReviewType", "review_UploadTime", "review_UserId" },
                values: new object[,]
                {
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "Test", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "Test", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "C2A543C2-B1E2-4DC5-A131-9137E4673FA6", "Test", false, "Review", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "DE544998-A3CC-4E12-ABB4-0642E57BD222" }
                });

            migrationBuilder.InsertData(
                table: "SubReview",
                columns: new[] { "subReview_Id", "subReview_Commnet", "subReview_DateCommnet", "subReview_HideStatus", "subReview_UserId", "subreview_SubReviewType" },
                values: new object[,]
                {
                    { "0430ae88-db4f-45d7-83a5-c11533d9841a", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff", "SubReview" },
                    { "d279fb6a-7006-40f3-bfff-5ffff527b56c", "subreview 3", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" },
                    { "f998bff9-3cef-4e18-94c9-ab11db926d5d", "subreview 1", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "DE544998-A3CC-4E12-ABB4-0642E57BD222", "SubReview" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" },
                    { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "wl_Id", "wl_UserId" },
                values: new object[] { 1, "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" });

            migrationBuilder.InsertData(
                table: "ProductInCart",
                columns: new[] { "pic_CartId", "pic_Id", "pic_ProductId", "pic_amount", "pic_color", "pic_size" },
                values: new object[,]
                {
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "1d67db26-2b47-4281-b54f-b243096879d7", 1, 2, "blue", "7" },
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "be325610-0e7a-4d84-9183-289d5a9521bb", 2, 3, "blue", "7.5" },
                    { "D355458F-1DD3-4834-AA28-6DA34B6357FF", "e8cc80b9-5cdc-480c-8151-b799e58678ad", 3, 1, "blue", "8" }
                });

            migrationBuilder.InsertData(
                table: "ProductInWishlist",
                columns: new[] { "piw_ProductId", "piw_WishlistId", "piw_amount" },
                values: new object[] { 1, 1, 0 });

            migrationBuilder.InsertData(
                table: "ReviewInproduct",
                columns: new[] { "rip_ProductId", "rip_ReviewId" },
                values: new object[,]
                {
                    { 1, "EEBA6608-AB75-4E83-909F-604B1A06F16C" },
                    { 1, "C2A543C2-B1E2-4DC5-A131-9137E4673FA6" },
                    { 1, "9EED8607-D2BB-45EE-AEE3-C59D858A7F97" }
                });

            migrationBuilder.InsertData(
                table: "SubReviewInReview",
                columns: new[] { "SRiR_ReviewId", "SRiR_SubReviewId" },
                values: new object[,]
                {
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "f998bff9-3cef-4e18-94c9-ab11db926d5d" },
                    { "9EED8607-D2BB-45EE-AEE3-C59D858A7F97", "d279fb6a-7006-40f3-bfff-5ffff527b56c" },
                    { "EEBA6608-AB75-4E83-909F-604B1A06F16C", "0430ae88-db4f-45d7-83a5-c11533d9841a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_cart_UserID",
                table: "Carts",
                column: "cart_UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CartsDevice_cartd_DeviceId",
                table: "CartsDevice",
                column: "cartd_DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCart_pic_ProductId",
                table: "ProductInCart",
                column: "pic_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInCartDevices_picd_ProductId",
                table: "ProductInCartDevices",
                column: "picd_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInWishlist_piw_ProductId",
                table: "ProductInWishlist",
                column: "piw_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInCategories_pic_CategoriesId",
                table: "ProductsInCategories",
                column: "pic_CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewInproduct_rip_ReviewId",
                table: "ReviewInproduct",
                column: "rip_ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_review_UserId",
                table: "Reviews",
                column: "review_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReview_subReview_UserId",
                table: "SubReview",
                column: "subReview_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubReviewInReview_SRiR_SubReviewId",
                table: "SubReviewInReview",
                column: "SRiR_SubReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_wl_UserId",
                table: "Wishlists",
                column: "wl_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleClaims_Roles_RoleId",
                table: "RoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserClaims_Users_UserId",
                table: "UserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLogins_Users_UserId",
                table: "UserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Roles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_Users_UserId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTokens_Users_UserId",
                table: "UserTokens");

            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "CategoriesHome");

            migrationBuilder.DropTable(
                name: "ContactSystems");

            migrationBuilder.DropTable(
                name: "ContactUsers");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "CustomerHome");

            migrationBuilder.DropTable(
                name: "FeatureHome");

            migrationBuilder.DropTable(
                name: "ProductInCart");

            migrationBuilder.DropTable(
                name: "ProductInCartDevices");

            migrationBuilder.DropTable(
                name: "ProductInWishlist");

            migrationBuilder.DropTable(
                name: "ProductsInCategories");

            migrationBuilder.DropTable(
                name: "ReviewInproduct");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "SliderHome");

            migrationBuilder.DropTable(
                name: "SubReviewInReview");

            migrationBuilder.DropTable(
                name: "Subsriber");

            migrationBuilder.DropTable(
                name: "UserInRoleModel");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "CartsDevice");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "SubReview");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTokens",
                table: "UserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogins",
                table: "UserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaims",
                table: "UserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaims",
                table: "RoleClaims");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "360E601E-92F2-4F08-832B-604A21293258", "DE544998-A3CC-4E12-ABB4-0642E57BD222" });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd", "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "360E601E-92F2-4F08-832B-604A21293258");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb4fd");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "DE544998-A3CC-4E12-ABB4-0642E57BD222");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "f49e4348-718f-43e3-b1f6-6dc89c5Bb5ff");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DoB",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "bill_Address1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "bill_Address2",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "bill_City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "bill_CompanyName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "bill_Country",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "bill_PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "bill_PostalCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "bill_State",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Roles");

            migrationBuilder.RenameTable(
                name: "UserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "RoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_UserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_RoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
