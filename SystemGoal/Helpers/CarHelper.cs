using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemGoal.Helpers
{
    public static class CarHelper
    {
        public static string GetStatus(int status)
        {
            var value = "";
            switch (status)
            {
                case 1:
                    value = "disponible";
                    break;
                case 2:
                    value = "Revisión caducada";
                    break;
                case 3:
                    value = "En ruta";
                    break;
            }
            return value;
        }

        public static string GetStatusReview(DateTime date)
        {
            var dateExpired = 1;
            var value = "";

            if (DateTime.Today > date.AddDays(-5))
            {
                dateExpired = 2;
            }

            if (DateTime.Today >= date)
            {
                dateExpired = 3;
            }

            switch (dateExpired)
            {
                case 1:
                    value = "<i class='material-icons'>build</i>";
                    break;
                case 2:
                    value = "<i class='material-icons' style='color:orange'>build</i>";
                    break;
                case 3:
                    value = "<i class='material-icons' style='color:red'>build</i>";
                    break;
            }

            return value;
        }
    }
}