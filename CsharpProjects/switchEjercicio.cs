string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{

    case "01":
        {
            type = "Sweat shirt";
            break;
        }

    case "02":
        {
            type = "T-shirt";
            break;
        }

    case "03":
        {
            type = "Sweat pants";
            break;
        }


    default:
        type = "other";
        break;
}

switch (product[1])
{

    case "BL":
        {
            color = "Black";
            break;
        }

    case "MN":
        {
            color = "Maroon";
            break;
        }

    default:
        color = "white";
        break;
}

switch (product[2])
{

    case "S":
        {
            size = "Small";
            break;
        }

    case "M":
        {
            size = "Medium";
            break;
        }

    case "L":
        {
            size = "Large";
            break;
        }


    default:
        size = "One size fits All";
        break;
}


Console.WriteLine($"Product: {size} {color} {type}");
