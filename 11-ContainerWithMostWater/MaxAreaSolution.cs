using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ContainerWithMostWater
{
    internal class MaxAreaSolution
    {
        public int MaxArea2(int[] height)
        {
            if (height == null || height.Length < 2)
            {
                return 0;
            }

            int maxHeigth = height.Max(height => height);
            int secondMax = height.Where(h => h < maxHeigth).DefaultIfEmpty().Max();
            if (secondMax == 0)
            {
                secondMax = maxHeigth;
            }
            int maxArea = 0;

            int indexMax = Array.IndexOf(height, maxHeigth);
            int indexSecondMax = Array.IndexOf(height, secondMax);

            int distance = Math.Abs(indexMax - indexSecondMax);

            maxArea = distance * secondMax;
            Console.WriteLine($"Max Height: {maxHeigth} secondMax: {secondMax} distance: {distance}");
            return maxArea;
        }

        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                int width = right - left;
                int minHeigth = Math.Min(height[left], height[right]);
                maxArea = Math.Max(maxArea, width * minHeigth);
                Console.WriteLine($"Max Area: {maxArea} left: {left} right: {right} width: {width} " +
                    $"minHeigth: {minHeigth} maxArea: {maxArea}");

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
             return maxArea;
        }
    }
}
