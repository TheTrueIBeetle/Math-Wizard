using DSharpPlus.CommandsNext;
/* File Name: GeometryCommands.cs
 * Author: Luke Bas
 * Project Name: CSharpBotv2
 * Last Date Published: Jan. 31 2021
 */

using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBotv2.Commands
{
    public sealed class GeometryCommands : BaseCommandModule
    {
        //2D Geometry
        [Command("AreaCircle")]
        [Description("Finds the area of a circle with the given radius")]
        public async Task AreaCircle(CommandContext ctx, [Description("Radius")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(findAreaCircle(num).ToString()).ConfigureAwait(false);
        }

        [Command("Circumference")]
        [Description("Finds the perimeter of a circle with the given radius")]
        public async Task PerimeterCircle(CommandContext ctx, [Description("Radius")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterCircle(num).ToString()).ConfigureAwait(false);
        }

        [Command("DiameterCircle")]
        [Description("Finds the diameter of a circle with the given radius")]
        public async Task DiameterCircle(CommandContext ctx, [Description("Radius")] decimal num)
        {
            await ctx.Channel.SendMessageAsync(findDiameterCircle(num).ToString()).ConfigureAwait(false);
        }

        [Command("AreaRectangle")]
        [Description("Finds the area of a rectangle with the given length and width")]
        public async Task AreaRectangle(CommandContext ctx, [Description("Length")] decimal length, [Description("Width")]
         decimal width)
        {
            await ctx.Channel.SendMessageAsync(findAreaRectangle(length, width).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterRectangle")]
        [Description("Finds the perimeter of a rectangle with the given length and width")]
        public async Task PerimeterRectangle(CommandContext ctx, [Description("Length")] decimal length, 
            [Description("Width")] decimal width)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterRectangle(length, width).ToString()).ConfigureAwait(false);
        }

        [Command("DiagonalRectangle")]
        [Description("Finds the diagonal of a rectangle with the given length and width")]
        public async Task DiagonalRectangle(CommandContext ctx, [Description("Length")] decimal length,
            [Description("Width")] decimal width)
        {
            await ctx.Channel.SendMessageAsync(findDiagonalRectangle(length, width).ToString()).ConfigureAwait(false);
        }

        [Command("AreaRhombus")]
        [Description("Finds the area of a rhombus with the given two inner diagonals")]
        public async Task AreaRhombus (CommandContext ctx,
            [Description("Diagonal 1")] decimal diagonal1, [Description("Diagonal 2")] decimal diagonal2)
        {
            await ctx.Channel.SendMessageAsync(findAreaRhombus(diagonal1, diagonal2).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterRhombus")]
        [Description("Finds the perimeter of a rhombus with the given side length")]
        public async Task PerimeterRhombus(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterRhombus(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("AreaTrapezoid")]
        [Description("Finds the area of a trapezoid with the two given bases and a height")]
        public async Task AreaTrapezoid(CommandContext ctx, [Description("Base 1")] decimal base1,
            [Description("Base 2")] decimal base2, [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findAreaTrapezoid(base1, base2, height).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterTrapezoid")]
        [Description("Finds the perimeter of a trapezoid with the two given bases and two given sides")]

        public async Task PerimeterTrapezoid(CommandContext ctx, [Description("Base 1")] decimal base1, 
            [Description("Base 2")] decimal base2, [Description("Side Length 1")] decimal sideLength1, 
            [Description("Side Length 2")] decimal sideLength2)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterTrapezoid(base1, base2, sideLength1, sideLength2).ToString()).ConfigureAwait(false);
        }

        [Command("AreaPentagon")]
        [Description("Finds the area of a pentagon with the given side length")]
        public async Task AreaPentagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findAreaPentagon(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterPentagon")]
        [Description("Finds the perimeter of a pentagon with the given sidelength")]
        public async Task PerimeterPentagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterPentagon(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("AreaHexagon")]
        [Description("Finds the area of a hexagon with the given side length")]
        public async Task AreaHexagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findAreaHexagon(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterHexagon")]
        [Description("Finds the perimeter of a hexagon with the given side length")]
        public async Task PerimeterHexagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterHexagon(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("AreaHeptagon")]
        [Description("Finds the area of a heptagon with the given side length")]
        public async Task AreaHeptagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findAreaHeptagon(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterHeptagon")]
        [Description("Finds the perimeter of a heptagon with the given side length")]
        public async Task PerimeterHeptagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterHeptagon(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("AreaOctagon")]
        [Description("Finds the area of an octagon with the given side length")]
        public async Task AreaOctagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findAreaOctagon(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterOctagon")]
        [Description("Finds the perimeter of an octagon with the given side length")]
        public async Task PerimeterOctagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterOctagon(sideLength).ToString()).ConfigureAwait(false);
        } 

        [Command("AreaNonagon")]
        [Description("Finds the area of a nonagon with the given side length")]
        public async Task AreaNonagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findAreaNonagon(sideLength).ToString()).ConfigureAwait(false);
        }

        [Command("PerimeterNonagon")]
        [Description("Finds the perimeter of a nonagon with the given side length")]
        public async Task PerimeterNonagon(CommandContext ctx, [Description("Side Length")] decimal sideLength)
        {
            await ctx.Channel.SendMessageAsync(findPerimeterNonagon(sideLength).ToString()).ConfigureAwait(false);
        }

        //3D Geometry
        [Command("AreaSphere")]
        [Description("Finds the surface area of a sphere with the given radius")]
        public async Task AreaSphere(CommandContext ctx, [Description("Radius")] decimal radius)
        {
            await ctx.Channel.SendMessageAsync(findAreaSphere(radius).ToString()).ConfigureAwait(false);
        }

        [Command("VolumeSphere")]
        [Description("Finds the volume of a sphere with a given radius")]
        public async Task VolumeSphere(CommandContext ctx, [Description("Radius")] decimal radius)
        {
            await ctx.Channel.SendMessageAsync(findVolumeSphere(radius).ToString()).ConfigureAwait(false);
        }

        [Command("AreaRecPrism")]
        [Description("Finds the surface area of a rectangular prism with a given length, width, and height")]
        public async Task AreaRecPrism(CommandContext ctx, [Description("Length")] decimal length,
            [Description("Width")] decimal width, [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findAreaRecPrism(length, width, height).ToString()).ConfigureAwait(false);
        }

        [Command("VolumeRecPrism")]
        [Description("Finds the volume of a rectangular prism with a given length, width, and height")]
        public async Task AreaVolumePrism(CommandContext ctx, [Description("Length")] decimal length,
            [Description("Width")] decimal width, [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findVolumeRecPrism(length, width, height).ToString()).ConfigureAwait(false);
        }

        [Command("AreaCylinder")]
        [Description("Finds the total surface area of a cylinder with a given radius and height")]
        public async Task AreaCylinder(CommandContext ctx, [Description("Radius")] decimal radius, 
            [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findAreaCylinder(radius, height).ToString()).ConfigureAwait(false);
        }

        [Command("VolumeCylinder")]
        [Description("Finds the volume of a cylinder with a given radius and height")]
        public async Task VolumeCylinder(CommandContext ctx, [Description("Radius")] decimal radius,
            [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findVolumeCylinder(radius, height).ToString()).ConfigureAwait(false);
        }

        [Command("AreaCone")]
        [Description("Finds the total surface area of a cone with a given radius and height")]
        public async Task AreaCone(CommandContext ctx, [Description("Radius")] decimal radius,
            [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findAreaCone(radius, height).ToString()).ConfigureAwait(false);
        }

        [Command("VolumeCone")]
        [Description("Finds the volume of a cone with a given radius and height")]
        public async Task VolumeCone(CommandContext ctx, [Description("Radius")] decimal radius,
            [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findVolumeCone(radius, height).ToString()).ConfigureAwait(false);
        }

        [Command("SlantCone")]
        [Description("Finds the slant height of a cone with a given radius and height")]
        public async Task SlantCone(CommandContext ctx, [Description("Radius")] decimal radius,
            [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findSlantHeightCone(radius, height).ToString()).ConfigureAwait(false);
        }

        [Command("AreaTetrahedron")]
        [Description("Finds the total surface area of a tetrahedron with a given edge length")]
        public async Task AreaTetrahedron(CommandContext ctx, [Description("Edge")] decimal edge)
        {
            await ctx.Channel.SendMessageAsync(findAreaTetrahedron(edge).ToString()).ConfigureAwait(false);
        }

        [Command("VolumeTetrahedron")]
        [Description("Finds the total volume of a tetrahedron with a given edge length")]
        public async Task VolumeTetrahedron(CommandContext ctx, [Description("Edge")] decimal edge)
        {
            await ctx.Channel.SendMessageAsync(findVolumeTetrahedron(edge).ToString()).ConfigureAwait(false);
        }

        [Command("AreaTorus")]
        [Description("Finds the total surface area of a torus with the given major radius, and minor radius")]
        public async Task AreaTorus(CommandContext ctx, [Description("Major Radius")] decimal majorRadius,
            [Description("Minor Radius")] decimal minorRadius)
        {
            if (majorRadius < minorRadius)
            {
                await ctx.Channel.SendMessageAsync("Major radius must be larger than minor radius; Calculation is impossible")
                    .ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync(findAreaTorus(majorRadius, minorRadius).ToString()).ConfigureAwait(false);
            }
        }

        [Command("VolumeTorus")]
        [Description("Finds the total volume of a torus with the given major radius, and minor radius")]
        public async Task VolumeTorus(CommandContext ctx, [Description("Major Radius")] decimal majorRadius,
            [Description("Minor Radius")] decimal minorRadius)
        {
            if (majorRadius < minorRadius)
            {
                await ctx.Channel.SendMessageAsync("Major radius must be larger than minor radius; calculation is impossible")
                    .ConfigureAwait(false);
            }
            else
            {
                await ctx.Channel.SendMessageAsync(findVolumeTorus(majorRadius, minorRadius).ToString()).ConfigureAwait(false);
            }
        }

        [Command("AreaRecPyramid")]
        [Description("Finds the total surface area of a rectangular pyramid with the given length, width, and height")]
        public async Task AreaRecPyramid(CommandContext ctx, [Description("Length")] decimal length, 
            [Description("Width")] decimal width, [Description("Height")] decimal height)
        {
            //await ctx.Channel.SendMessageAsync(findAreaRecPyramid(length, width, height).ToString()).ConfigureAwait(false);
            await ctx.Channel.SendMessageAsync("Currently, this command is out of commission for bug tests. Sorry for the inconvenience");
        }

        [Command("VolumeRecPyramid")]
        [Description("Finds the total volume of a rectangular pyramid with the given length, width, and height")]
        public async Task VolumeRecPyramid(CommandContext ctx, [Description("Length")] decimal length,
            [Description("Width")] decimal width, [Description("Height")] decimal height)
        {
            await ctx.Channel.SendMessageAsync(findVolumeRecPyramid(length, width, height).ToString()).ConfigureAwait(false);
        }



        //Helper methods 
        private decimal findAreaCircle(decimal radius)
        {
            const decimal PI = 3.14M;
            decimal finalArea = PI * radius * radius;
            return finalArea;
        }
        private decimal findPerimeterCircle(decimal radius)
        {
            const decimal PI = 3.14M;
            decimal finalPerim = 2.0M * PI * radius;
            return finalPerim;
        }
        private decimal findDiameterCircle(decimal radius)
        {
            decimal finalRadius = 2.0M * radius;
            return finalRadius;
        }
        private decimal findAreaRectangle(decimal length, decimal width)
        {
            decimal finalArea = length * width;
            return finalArea;
        }
        private decimal findPerimeterRectangle(decimal length, decimal width)
        {
            decimal finalPerim = 2 * (length + width);
            return finalPerim;
        }
        private decimal findDiagonalRectangle(decimal length, decimal width)
        {
            decimal temp;
            decimal finalDiag;
            temp = (width * width) + (length * length); 
            finalDiag = squareRoot(temp);
            return finalDiag;
        }
        private decimal findAreaRhombus(decimal diag1, decimal diag2)
        {
            decimal finalArea = (diag1 * diag2) / 2;
            return finalArea;
        }
        private decimal findPerimeterRhombus(decimal sideLength)
        {
            decimal finalPerim = 4 * sideLength;
            return finalPerim;
        }
        private decimal findAreaTrapezoid(decimal base1, decimal base2, decimal height)
        {
            decimal finalArea = ((base1 + base2) / 2) * height;
            return finalArea;
        }
        private decimal findPerimeterTrapezoid(decimal base1, decimal base2, decimal sideLength1, decimal sideLength2)
        {
            decimal finalPerim = base1 + base2 + sideLength1 + sideLength2;
            return finalPerim;
        }
        private decimal findAreaPentagon(decimal sideLength)
        {
            decimal finalArea;
            finalArea = (squareRoot(5 * (5 + 2 * (squareRoot(5)))) * sideLength * sideLength) / 4;
            return finalArea;
        }
        private decimal findPerimeterPentagon(decimal sideLength)
        {
            decimal finalPerim = 5 * sideLength;
            return finalPerim;
        }
        private decimal findAreaHexagon(decimal sideLength)
        {
            decimal finalArea = ((3 * squareRoot(3)) / 2) * sideLength * sideLength;
            return finalArea;
        }
        private decimal findPerimeterHexagon(decimal sideLength)
        {
            decimal finalPerimeter = 6M * sideLength;
            return finalPerimeter;
        }
        private decimal findAreaOctagon(decimal sideLength)
        {
            decimal finalArea = (2 * (1 + squareRoot(2))) * sideLength * sideLength;
            return finalArea;
        }
        private decimal findPerimeterOctagon(decimal sideLength)
        {
            decimal finalPerimeter = 8 * sideLength;
            return finalPerimeter;
        }
        private decimal findAreaNonagon(decimal sideLength)
        {
            decimal finalArea = 6.18182M * power(sideLength, 2);
            return finalArea; 
        }
        private decimal findPerimeterNonagon(decimal sideLength)
        {
            decimal finalPerim = 9 * sideLength;
            return finalPerim;
        }
        private decimal findAreaHeptagon(decimal sideLength)
        {
            decimal finalArea = 3.633912444M * power(sideLength, 2);
            return finalArea;
        }
        private decimal findPerimeterHeptagon(decimal sideLength)
        {
            decimal finalPerim = 7 * sideLength;
            return finalPerim;
        }
        private decimal findAreaSphere(decimal radius)
        {
            decimal finalArea = 4 * 3.14159265359M * radius * radius;
            return finalArea;
        }
        private decimal findVolumeSphere(decimal radius)
        {
            decimal temp = 1.333333333333333M * 3.14159265359M;
            decimal finalVolume = temp * (radius * radius * radius);
            return finalVolume;
        }
        private decimal findAreaRecPrism(decimal length, decimal width, decimal height)
        {
            decimal finalArea = 2 * ((width * length) + (height * length) + (height * width));
            return finalArea;
        }
        private decimal findVolumeRecPrism(decimal length, decimal width, decimal height)
        {
            decimal finalVolume = width * length * height;
            return finalVolume;
        }
        private decimal findAreaCylinder(decimal radius, decimal height)
        {
            decimal finalArea = (2 * 3.14159265359M * radius * height) + (2 * 3.14159265359M * radius * radius);
            return finalArea;
        }
        private decimal findVolumeCylinder(decimal radius, decimal height)
        {
            decimal finalVolume = 3.14159265359M * radius * radius * height;
            return finalVolume;
        }
        private decimal findAreaCone(decimal radius, decimal height)
        {
            decimal finalArea = 3.14159265359M * radius * (radius + squareRoot((height * height) + (radius * radius)));
            return finalArea;
        }
        private decimal findVolumeCone(decimal radius, decimal height)
        {
            decimal finalVolume = 3.14159265359M * radius * radius * (height / 3);
            return finalVolume;
        }
        private decimal findSlantHeightCone(decimal radius, decimal height)
        {
            decimal finalSlant = squareRoot((radius * radius) + (height * height));
            return finalSlant;
        }
        private decimal findAreaTetrahedron(decimal edge)
        {
            decimal finalArea = 4 * ((squareRoot(3) / 4) * edge * edge);
            return finalArea;
        }
        private decimal findVolumeTetrahedron(decimal edge)
        {
            decimal finalVolume = (edge * edge * edge) / (6 * (squareRoot(2)));
            return finalVolume;
        }
        private decimal findAreaTorus(decimal majorRadius, decimal minorRadius)
        {
            const decimal PI = 3.14159265359M;
            decimal finalArea = (2 * PI * majorRadius) * (2 * PI * minorRadius);
            return finalArea;
        }
        private decimal findVolumeTorus(decimal majorRadius, decimal minorRadius)
        {
            const decimal PI = 3.14159265359M; ;
            decimal finalVolume = (PI * minorRadius * minorRadius) * (2 * PI * majorRadius);
            return finalVolume;
        }
        private decimal findAreaRecPyramid(decimal length, decimal width, decimal height)
        {
            decimal finalArea = (length * width) + length * (squareRoot((width / 2) * (width / 2) + (height * height) +
                width) * squareRoot((0.5M * 0.5M) + (height * height)));
            return finalArea;
        }
        private decimal findVolumeRecPyramid(decimal length, decimal width, decimal height)
        {
            decimal finalVolume = (length * width * height) / 3;
            return finalVolume;
        }

        //Extra helps
        private decimal squareRoot(decimal _d)
        {
            decimal x = 0;
            decimal y = 2;
            decimal z = 1;
            decimal w = _d;
            decimal h = 1;
            decimal t = 0;
            decimal px = 0;
            int itr = 0;
            while (true)
            {
                w = (w / y);
                h *= y;
                if (h > w)
                {
                    t = w;
                    w = h;
                    h = t;
                    z *= 0.5M;
                    y = (1 + z);
                }
                x = ((w + h) * 0.5M);
                if (itr >= 100 || w == h || px == x)
                {
                    return (x);
                }
                px = x;
                itr++;
            }
        }
        private decimal power(decimal num1, decimal num2) 
        {
            int count = 1;
            decimal pow = num1;
            while (count < num2)
            {
                pow *= num1;
                count++;
            }
            return pow;
        }

    }
}
