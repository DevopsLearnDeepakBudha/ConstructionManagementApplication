using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ContructionManagementApplication.common.NepaliCalendar
{
    public class NepaliDate
    {
        public DateTime Starting_Range_AD { get; set; } = new DateTime(1943, 4, 14);
        public List<YearsMonthsNumber> dateDBs { get; set; }
        private List<YearsMonthsNumber> BS_Database()
        {
            dateDBs = new List<YearsMonthsNumber>()
            {
                        new YearsMonthsNumber() { Year=2000, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2001, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2002, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2003, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2004, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2005, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2006, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2007, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2008, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=30, Magh=29, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2009, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2010, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2011, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2012, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2013, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2014, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2015, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2016, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2017, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2018, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2019, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2020, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2021, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2022, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2023, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2024, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2025, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2026, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2027, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2028, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2029, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=32, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2030, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2031, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2032, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2033, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2034, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2035, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=30, Magh=29, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2036, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2037, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2038, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2039, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2040, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2041, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2042, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2043, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2044, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2045, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2046, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2047, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2048, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2049, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2050, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2051, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2052, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2053, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2054, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2055, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2056, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=32, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2057, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2058, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2059, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2060, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2061, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2062, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2063, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2064, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2065, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2066, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=30, Magh=29, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2067, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2068, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2069, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2070, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=29, Mangsir=30, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2071, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2072, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2073, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=31},
                        new YearsMonthsNumber() { Year=2074, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2075, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2076, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2077, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=29, Chait=31},
                        new YearsMonthsNumber() { Year=2078, Baishakh=31, Jestha=31, Asar=31, Saun=32, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2079, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=29, Pusa=30, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2080, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=29, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2081, Baishakh=31, Jestha=31, Asar=32, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2082, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2083, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2084, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2085, Baishakh=31, Jestha=32, Asar=31, Saun=32, Bhadau=30, Asoj=31, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2086, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2087, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2088, Baishakh=30, Jestha=31, Asar=32, Saun=32, Bhadau=30, Asoj=31, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2089, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2090, Baishakh=30, Jestha=32, Asar=31, Saun=32, Bhadau=31, Asoj=30, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30},
                        new YearsMonthsNumber() { Year=2091, Baishakh=31, Jestha=31, Asar=32, Saun=31, Bhadau=31, Asoj=31, Kattik=30, Mangsir=30, Pusa=29, Magh=30, Fagun=30, Chait=30}
            };
            return dateDBs;
        }
        public CustomDateView AD2BS(DateTime AD) // Function for converting AD to BS
        {
            CustomDate customDate = new CustomDate();
            CustomDateView customDateView = new CustomDateView(); //returning BS value
            try
            {
                ///Calling the database in memory
                if (dateDBs == null || dateDBs.Count <= 0)
                {
                    dateDBs = BS_Database();
                }

                AD = new DateTime(AD.Year, AD.Month, AD.Day);
                double DD_Gap = (AD - Starting_Range_AD).TotalDays;// calculating the days difference between entered AD date and starting database AD date

                if (DD_Gap < 0) // condition for checking whether the entered AD date is befor the starting AD date in the database
                {
                    customDateView.customDate = customDate;
                    customDateView.IsSuccess = false;
                    customDateView.Message = "Error! Out of range..."; // returning error 
                    return customDateView;
                }

                double DD_total = 0; // creating variable for cummulative days in the database
                foreach (var item in dateDBs) // Loop for each year
                {
                    PropertyInfo[] properties = item.GetType().GetProperties();
                    for (int month = 0; month < properties.Length; month++)
                    {
                        // calculating cummulative days by adding days in each months
                        if (month > 0)
                        {
                            PropertyInfo propertyInfo = properties[month];
                            double DaysInMonth = Convert.ToDouble(propertyInfo.GetValue(item, null));
                            DD_total += DaysInMonth;
                            if (DD_total > DD_Gap)
                            {
                                DD_total -= DaysInMonth; // reversing the last addition of days
                                customDate.Year = item.Year;
                                customDate.Month = month;
                                customDate.Day = Convert.ToInt32((DD_Gap - DD_total + 1));
                                customDateView.IsSuccess = true;
                                customDateView.Message = "success";
                                break;
                            }
                        }
                    }
                    if (customDateView.IsSuccess) break;
                }

                customDateView.customDate = customDate;
                customDateView.DateTime = new DateTime(customDate.Year, customDate.Month, customDate.Day);
            }
            catch (Exception ex)
            {
                customDateView.IsSuccess = false;
                customDateView.Message = ex.Message;
            }
            return customDateView;
        }
        public CustomDateView BS2AD(DateTime BS_Date) // converts BS date into AD date.
        {
            //Calling the database in memory
            if (dateDBs == null || dateDBs.Count <= 0)
            {
                dateDBs = BS_Database();
            }

            CustomDate customDate = new CustomDate();
            CustomDateView customDateView = new CustomDateView(); //returning BS value

            //Boolean variable for checking whether entered BS falls within the database range
            YearsMonthsNumber BS_Index = dateDBs.Where(x => x.Year == BS_Date.Year).FirstOrDefault();
            if (BS_Index == null) { return customDateView; }

            double DD_total = 0;  //'creating variable for cummulative days in the database
            foreach (YearsMonthsNumber item in dateDBs) // loop for each year until the desired BS index year is reached
            {
                PropertyInfo[] properties = item.GetType().GetProperties();
                for (int month = 0; month < properties.Length; month++)
                {
                    if (month > 0)
                    {
                        PropertyInfo propertyInfo = properties[month];

                        if (BS_Index.Year == item.Year && BS_Date.Month == month)
                        {
                            customDateView.DateTime = Starting_Range_AD.AddDays(DD_total + BS_Date.Day - 1);
                            customDate.Year = customDateView.DateTime.Year;
                            customDate.Month = customDateView.DateTime.Month;
                            customDate.Day = customDateView.DateTime.Day;
                            customDateView.IsSuccess = true;
                            customDateView.Message = "success";
                            break;
                        }
                        DD_total += Convert.ToDouble(propertyInfo.GetValue(item, null));
                    }
                }
                if (customDateView.IsSuccess) break;
            }
            customDateView.customDate = customDate;
            return customDateView;
        }
        public int BS_Date_Diff(DateTime frmDate, DateTime toDate) // returns the days between BS date1 and BS date 2.
        {
            return Convert.ToInt32((toDate - frmDate).TotalDays);
        }
        public DateTime BS_Date_Day_Add(DateTime BSdate, int daystoadd) // returns the BS date by adding days in given BS date.
        {
            return BSdate.AddDays(daystoadd);
        }
        public int BS_Day_Of_Week(DateTime BSdate) // returns day of week in BS Date.
        {
            DayOfWeek dayOfWeek = BSdate.DayOfWeek;
            return (int)dayOfWeek;
        }
        public int BS_Year(DateTime BSdate) // returns year in the BS date.
        {
            return BSdate.Year;
        }
        public int BS_Month(DateTime BSdate) // returns month in the BS date.
        {
            return BSdate.Month;
        }
        public int BS_Day(DateTime BSdate) // returns day in the BS date.
        {
            return BSdate.Day;
        }
    }
    public class YearsMonthsNumber
    {
        public int Year { get; set; }
        public int Baishakh { get; set; }
        public int Jestha { get; set; }
        public int Asar { get; set; }
        public int Saun { get; set; }
        public int Bhadau { get; set; }
        public int Asoj { get; set; }
        public int Kattik { get; set; }
        public int Mangsir { get; set; }
        public int Pusa { get; set; }
        public int Magh { get; set; }
        public int Fagun { get; set; }
        public int Chait { get; set; }
    }
    public class CustomDateView
    {
        public DateTime DateTime { get; set; }
        public CustomDate customDate { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    public class CustomDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }

    public enum NepaleseMonth
    {
        Baishakh = 1,
        Jestha,
        Asar,
        Saun,
        Bhadau,
        Asoj,
        Kattik,
        Mangsir,
        Pusa,
        Magh,
        Fagun,
        Chait,
    }
}
