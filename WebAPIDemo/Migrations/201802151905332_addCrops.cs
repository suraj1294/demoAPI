namespace WebAPIDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCrops : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Crops VALUES ('Ash Gourd',N'पेठा	')");
            Sql("INSERT INTO Crops VALUES ('Beetroot',N'चकुंदर')");
            Sql("INSERT INTO Crops VALUES ('Bitter Gourd',N'करेला')");
            Sql("INSERT INTO Crops VALUES ('Black Pepper',N'काली मिर्च	')");
            Sql("INSERT INTO Crops VALUES ('Bottle Gourd',N'लौकी	')");
            Sql("INSERT INTO Crops VALUES ('Cabbage',N'पत्तागोभी')");
            Sql("INSERT INTO Crops VALUES ('Capsicum',N'शिमला मिर्च')");
            Sql("INSERT INTO Crops VALUES ('Carrot',N'गाजर	')");
            Sql("INSERT INTO Crops VALUES ('Cauliflower',N'फूल गोभी')");
            Sql("INSERT INTO Crops VALUES ('Coriander Leaf',N'हरा धनिया')");
            Sql("INSERT INTO Crops VALUES ('Corn',N'मक्का')");
            Sql("INSERT INTO Crops VALUES ('Red Chilli',N'लाल मिर्च')");
            Sql("INSERT INTO Crops VALUES ('French Beans',N'गवार फली	')");
            Sql("INSERT INTO Crops VALUES ('Cucumber',N'खीरा')");
            Sql("INSERT INTO Crops VALUES ('Curry Leaf',N'कढ़ी पत्ता')");
            Sql("INSERT INTO Crops VALUES ('Brinjal',N'बैगन')");
            Sql("INSERT INTO Crops VALUES ('Chickpeas',N'चना')");
            Sql("INSERT INTO Crops VALUES ('Fenugreek Leaf',N'हरी मेथी')");
            Sql("INSERT INTO Crops VALUES ('Garlic',N'लहसुन')");
            Sql("INSERT INTO Crops VALUES ('Ginger',N'अदरक')");
            Sql("INSERT INTO Crops VALUES ('Green chilli',N'हरी मिर्च')");
            Sql("INSERT INTO Crops VALUES ('Lady Finger',N'भिन्डी')");
            Sql("INSERT INTO Crops VALUES ('Mushroom',N'कुकुरमुत्ता')");
            Sql("INSERT INTO Crops VALUES ('Mustard Greens',N'सरसों पत्ता')");
            Sql("INSERT INTO Crops VALUES ('Onion',N'प्याज')");
            Sql("INSERT INTO Crops VALUES ('Peas',N'मटर')");
            Sql("INSERT INTO Crops VALUES ('Peppermint',N'पुदीना')");
            Sql("INSERT INTO Crops VALUES ('Potato',N'आलू')");
            Sql("INSERT INTO Crops VALUES ('Radish',N'मूली')");
            Sql("INSERT INTO Crops VALUES ('Spinach',N'पालक')");
            Sql("INSERT INTO Crops VALUES ('Spring Onion',N'हरा प्याज़')");
            Sql("INSERT INTO Crops VALUES ('Sweet Potato',N'शकर कन्द')");
            Sql("INSERT INTO Crops VALUES ('Tomato',N'टमाटर')");
            Sql("INSERT INTO Crops VALUES ('Turmeric',N'हल्दी	')");
            Sql("INSERT INTO Crops VALUES ('Apple',N'सेब')");
            Sql("INSERT INTO Crops VALUES ('Apricot',N'खूबानी')");
            Sql("INSERT INTO Crops VALUES ('Banana',N'केला')");
            Sql("INSERT INTO Crops VALUES ('Blackberry',N'	कटहल	')");
            Sql("INSERT INTO Crops VALUES ('Blueberry',N'नीलबदरी')");
            Sql("INSERT INTO Crops VALUES ('Coconut',N'नारियल')");
            Sql("INSERT INTO Crops VALUES ('Custard',N'सीताफल')");
            Sql("INSERT INTO Crops VALUES ('Date',N'खजूर')");
            Sql("INSERT INTO Crops VALUES ('Fig',N'अंजीर')");
            Sql("INSERT INTO Crops VALUES ('Amla',N'आँवला')");
            Sql("INSERT INTO Crops VALUES ('Grapes',N'अंगूर्')");
            Sql("INSERT INTO Crops VALUES ('Guava',N'अमरूद्')");
            Sql("INSERT INTO Crops VALUES ('Jackfruit',N'कटहल')");
            Sql("INSERT INTO Crops VALUES ('Lemon',N'नींबू')");
            Sql("INSERT INTO Crops VALUES ('Lychee',N'लीची')");
            Sql("INSERT INTO Crops VALUES ('Mango',N'आम')");
            Sql("INSERT INTO Crops VALUES ('Mulberry',N'शहतूत')");
            Sql("INSERT INTO Crops VALUES ('Musk Melon',N'खरबुजा')");
            Sql("INSERT INTO Crops VALUES ('Orange',N'संतरा')");
            Sql("INSERT INTO Crops VALUES ('Papaya',N'पपीता')");
            Sql("INSERT INTO Crops VALUES ('Peach',N'आडू')");
            Sql("INSERT INTO Crops VALUES ('Pear',N'नाशपाती')");
            Sql("INSERT INTO Crops VALUES ('Pineapple',N'अनन्नास')");
            Sql("INSERT INTO Crops VALUES ('Pomegranate',N'अनार्')");
            Sql("INSERT INTO Crops VALUES ('Raisins',N'किसमिस')");
            Sql("INSERT INTO Crops VALUES ('Sapota',N'चीकू')");
            Sql("INSERT INTO Crops VALUES ('Sweetlime',N'मौसमी')");
            Sql("INSERT INTO Crops VALUES ('Tamarind',N'इमली')");
            Sql("INSERT INTO Crops VALUES ('Water Melon',N'तरबूज')");
            Sql("INSERT INTO Crops VALUES ('Wood Apple',N'बेल')");
        }
        
        public override void Down()
        {
        }
    }
}
