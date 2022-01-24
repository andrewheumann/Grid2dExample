using Elements;
using Elements.Geometry;
using Elements.Spatial;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grid2dExample
{
    public static class Grid2dExample
    {
        /// <summary>
        /// The Grid2dExample function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A Grid2dExampleOutputs instance containing computed results and the model with any new elements.</returns>
        public static Grid2dExampleOutputs Execute(Dictionary<string, Model> inputModels, Grid2dExampleInputs input)
        {
            /// Your code here.
            var output = new Grid2dExampleOutputs();
            var grid = new Grid2d(input.GridBoundaries, input.GridAlignmentTransform ?? new Transform());
            if (input.USplitPoints.Count > 0)
            {
                grid.U.SplitAtPoints(input.USplitPoints);
            }
            if (input.VSplitPoints.Count > 0)
            {
                grid.V.SplitAtPoints(input.VSplitPoints);
            }
            output.Model.AddElements(grid.ToModelCurves());

            return output;
        }
    }
}