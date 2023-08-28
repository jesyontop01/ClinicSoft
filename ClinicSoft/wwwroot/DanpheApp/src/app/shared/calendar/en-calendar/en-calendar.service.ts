import { Injectable } from '@angular/core';
import * as moment from 'moment/moment';


@Injectable()
export class EnglishCalendarService {

 

  //this array contains How many days were there in each months of Nepali Years
  public yr_mth_bs: Array<Array<number>>;
  public nep_mth_Dates: Array<number>;


  public minEngYear: number = 1901;
  public maxEngYear: number = 2090;

  //sud:21Aug'19--this will be used by nepali-calendar.component.
  //when month changes, it doesn't re-load the UI for Days, so we'll be using this shared variable.

  //these below static variables with name static appended at last are used for static Calender Service which is needed in the
  //grid cell renderer function --Anish: 30 March, 2020
  static yr_mth_bs_static: Array<Array<number>>;
  static nep_mth_Dates_static: Array<number>;
  static minNepYear_static: number = 1970;
  static maxNepYear_static: number = 2090;
  static minEngYear_static: number = 0;
  static maxEngYear_static: number = 0;





 



  static GetEngCalendarYearInfo(): Array<any> {
    let engYearsHash = [
      ////english calendar year data from 1900 to 1940 are not verified

      //data below are verified and are correct.., but above this are not..
      { engYear: 1900, yStartInBS: "1956-09-17", yEndInBS: "1957-09-17" },
      { engYear: 1901, yStartInBS: "1957-09-18", yEndInBS: "1958-09-17" },
      { engYear: 1902, yStartInBS: "1958-09-18", yEndInBS: "1959-09-16" },
      { engYear: 1903, yStartInBS: "1959-09-17", yEndInBS: "1960-09-16" },
      { engYear: 1904, yStartInBS: "1960-09-17", yEndInBS: "1961-09-17" },
      { engYear: 1905, yStartInBS: "1961-09-18", yEndInBS: "1962-09-17" },
      { engYear: 1906, yStartInBS: "1962-09-18", yEndInBS: "1963-09-16" },
      { engYear: 1907, yStartInBS: "1963-09-18", yEndInBS: "1963-09-17" },
      { engYear: 1908, yStartInBS: "1964-09-17", yEndInBS: "1964-09-17" },
      { engYear: 1909, yStartInBS: "1965-09-18", yEndInBS: "1965-09-17" },
      { engYear: 1910, yStartInBS: "1966-09-18", yEndInBS: "1966-09-16" },
      { engYear: 1911, yStartInBS: "1967-09-17", yEndInBS: "1967-09-16" },
      { engYear: 1912, yStartInBS: "1968-09-17", yEndInBS: "1968-09-17" },
      { engYear: 1913, yStartInBS: "1969-09-18", yEndInBS: "1969-09-17" },
      { engYear: 1914, yStartInBS: "1970-09-18", yEndInBS: "1970-09-16" },
      { engYear: 1915, yStartInBS: "1971-09-17", yEndInBS: "1971-09-16" },
      { engYear: 1916, yStartInBS: "1972-09-17", yEndInBS: "1972-09-17" },
      { engYear: 1917, yStartInBS: "1973-09-18", yEndInBS: "1973-09-17" },
      { engYear: 1918, yStartInBS: "1974-09-18", yEndInBS: "1974-09-16" },
      { engYear: 1919, yStartInBS: "1975-09-17", yEndInBS: "1975-09-16" },
      { engYear: 1920, yStartInBS: "1976-09-17", yEndInBS: "1976-09-17" },
      { engYear: 1921, yStartInBS: "1977-09-18", yEndInBS: "1977-09-17" },
      { engYear: 1922, yStartInBS: "1978-09-18", yEndInBS: "1978-09-16" },
      { engYear: 1923, yStartInBS: "1979-09-17", yEndInBS: "1979-09-16" },
      { engYear: 1924, yStartInBS: "1980-09-17", yEndInBS: "1980-09-17" },
      { engYear: 1925, yStartInBS: "1981-09-18", yEndInBS: "1981-09-16" },
      { engYear: 1926, yStartInBS: "1982-09-17", yEndInBS: "1982-09-16" },
      { engYear: 1927, yStartInBS: "1983-09-17", yEndInBS: "1983-09-16" },
      { engYear: 1928, yStartInBS: "1984-09-17", yEndInBS: "1984-09-17" },
      { engYear: 1929, yStartInBS: "1985-09-18", yEndInBS: "1985-09-16" },
      { engYear: 1930, yStartInBS: "1986-09-17", yEndInBS: "1986-09-16" },
      { engYear: 1931, yStartInBS: "1987-09-18", yEndInBS: "1987-09-17" },
      { engYear: 1932, yStartInBS: "1988-09-17", yEndInBS: "1989-09-16" },
      { engYear: 1933, yStartInBS: "1989-09-17", yEndInBS: "1990-09-17" },
      { engYear: 1934, yStartInBS: "1990-09-18", yEndInBS: "1991-09-16" },
      { engYear: 1935, yStartInBS: "1991-09-17", yEndInBS: "1992-09-16" },
      { engYear: 1936, yStartInBS: "1992-09-17", yEndInBS: "1993-09-16" },
      { engYear: 1937, yStartInBS: "1993-09-17", yEndInBS: "1994-09-17" },
      { engYear: 1938, yStartInBS: "1994-09-18", yEndInBS: "1995-09-16" },
      { engYear: 1939, yStartInBS: "1995-09-17", yEndInBS: "1996-09-16" },
      //data below are verified and are correct.., but above this are not..
      { engYear: 1940, yStartInBS: "1996-09-17", yEndInBS: "1997-09-17" },
      { engYear: 1941, yStartInBS: "1997-09-18", yEndInBS: "1998-09-17" },
      { engYear: 1942, yStartInBS: "1998-09-18", yEndInBS: "1999-09-16" },
      { engYear: 1943, yStartInBS: "1999-09-17", yEndInBS: "2000-09-16" },
      { engYear: 1944, yStartInBS: "2000-09-17", yEndInBS: "2001-09-17" },
      { engYear: 1945, yStartInBS: "2001-09-18", yEndInBS: "2002-09-17" },
      { engYear: 1946, yStartInBS: "2002-09-18", yEndInBS: "2003-09-16" },
      { engYear: 1947, yStartInBS: "2003-09-17", yEndInBS: "2004-09-16" },
      { engYear: 1948, yStartInBS: "2004-09-17", yEndInBS: "2005-09-17" },
      { engYear: 1949, yStartInBS: "2005-09-18", yEndInBS: "2006-09-17" },
      { engYear: 1950, yStartInBS: "2006-09-18", yEndInBS: "2007-09-16" },
      { engYear: 1951, yStartInBS: "2007-09-17", yEndInBS: "2008-09-16" },
      { engYear: 1952, yStartInBS: "2008-09-17", yEndInBS: "2009-09-17" },
      { engYear: 1953, yStartInBS: "2009-09-18", yEndInBS: "2010-09-17" },
      { engYear: 1954, yStartInBS: "2010-09-18", yEndInBS: "2011-09-16" },
      { engYear: 1955, yStartInBS: "2011-09-17", yEndInBS: "2012-09-16" },
      { engYear: 1956, yStartInBS: "2012-09-17", yEndInBS: "2013-09-17" },
      { engYear: 1957, yStartInBS: "2013-09-18", yEndInBS: "2014-09-17" },
      { engYear: 1958, yStartInBS: "2014-09-18", yEndInBS: "2015-09-16" },
      { engYear: 1959, yStartInBS: "2015-09-17", yEndInBS: "2016-09-16" },
      { engYear: 1960, yStartInBS: "2016-09-17", yEndInBS: "2017-09-17" },
      { engYear: 1961, yStartInBS: "2017-09-18", yEndInBS: "2018-09-17" },
      { engYear: 1962, yStartInBS: "2018-09-18", yEndInBS: "2019-09-16" },
      { engYear: 1963, yStartInBS: "2019-09-17", yEndInBS: "2020-09-16" },
      { engYear: 1964, yStartInBS: "2020-09-17", yEndInBS: "2021-09-17" },
      { engYear: 1965, yStartInBS: "2021-09-18", yEndInBS: "2022-09-16" },
      { engYear: 1966, yStartInBS: "2022-09-17", yEndInBS: "2023-09-16" },
      { engYear: 1967, yStartInBS: "2023-09-17", yEndInBS: "2024-09-16" },
      { engYear: 1968, yStartInBS: "2024-09-17", yEndInBS: "2025-09-17" },
      { engYear: 1969, yStartInBS: "2025-09-18", yEndInBS: "2026-09-16" },
      { engYear: 1970, yStartInBS: "2026-09-17", yEndInBS: "2027-09-16" },
      { engYear: 1971, yStartInBS: "2027-09-17", yEndInBS: "2028-09-16" },
      { engYear: 1972, yStartInBS: "2028-09-17", yEndInBS: "2029-09-17" },
      { engYear: 1973, yStartInBS: "2029-09-18", yEndInBS: "2030-09-16" },
      { engYear: 1974, yStartInBS: "2030-09-17", yEndInBS: "2031-09-16" },
      { engYear: 1975, yStartInBS: "2031-09-17", yEndInBS: "2032-09-16" },
      { engYear: 1976, yStartInBS: "2032-09-17", yEndInBS: "2033-09-17" },
      { engYear: 1977, yStartInBS: "2033-09-18", yEndInBS: "2034-09-16" },
      { engYear: 1978, yStartInBS: "2034-09-17", yEndInBS: "2035-09-16" },
      { engYear: 1979, yStartInBS: "2035-09-17", yEndInBS: "2036-09-16" },
      { engYear: 1980, yStartInBS: "2036-09-17", yEndInBS: "2037-09-17" },
      { engYear: 1981, yStartInBS: "2037-09-18", yEndInBS: "2038-09-16" },
      { engYear: 1982, yStartInBS: "2038-09-17", yEndInBS: "2039-09-16" },
      { engYear: 1983, yStartInBS: "2039-09-17", yEndInBS: "2040-09-16" },
      { engYear: 1984, yStartInBS: "2040-09-17", yEndInBS: "2041-09-17" },
      { engYear: 1985, yStartInBS: "2041-09-18", yEndInBS: "2042-09-16" },
      { engYear: 1986, yStartInBS: "2042-09-17", yEndInBS: "2043-09-16" },
      { engYear: 1987, yStartInBS: "2043-09-17", yEndInBS: "2044-09-16" },
      { engYear: 1988, yStartInBS: "2044-09-17", yEndInBS: "2045-09-17" },
      { engYear: 1989, yStartInBS: "2045-09-18", yEndInBS: "2046-09-17" },
      { engYear: 1990, yStartInBS: "2046-09-17", yEndInBS: "2047-09-16" },
      { engYear: 1991, yStartInBS: "2047-09-17", yEndInBS: "2048-09-16" },
      { engYear: 1992, yStartInBS: "2048-09-17", yEndInBS: "2049-09-16" },
      { engYear: 1993, yStartInBS: "2049-09-17", yEndInBS: "2050-09-16" },
      { engYear: 1994, yStartInBS: "2050-09-17", yEndInBS: "2051-09-16" },
      { engYear: 1995, yStartInBS: "2051-09-17", yEndInBS: "2052-09-16" },
      { engYear: 1996, yStartInBS: "2052-09-17", yEndInBS: "2053-09-16" },
      { engYear: 1997, yStartInBS: "2053-09-17", yEndInBS: "2054-09-16" },
      { engYear: 1998, yStartInBS: "2054-09-17", yEndInBS: "2055-09-16" },
      { engYear: 1999, yStartInBS: "2055-09-17", yEndInBS: "2056-09-16" },
      { engYear: 2000, yStartInBS: "2056-09-17", yEndInBS: "2057-09-16" },
      { engYear: 2001, yStartInBS: "2057-09-17", yEndInBS: "2058-09-16" },
      { engYear: 2002, yStartInBS: "2058-09-17", yEndInBS: "2059-09-16" },
      { engYear: 2003, yStartInBS: "2059-09-17", yEndInBS: "2060-09-16" },
      { engYear: 2004, yStartInBS: "2060-09-17", yEndInBS: "2061-09-16" },
      { engYear: 2005, yStartInBS: "2061-09-17", yEndInBS: "2062-09-16" },
      { engYear: 2006, yStartInBS: "2062-09-17", yEndInBS: "2063-09-16" },
      { engYear: 2007, yStartInBS: "2063-09-17", yEndInBS: "2064-09-16" },
      { engYear: 2008, yStartInBS: "2064-09-17", yEndInBS: "2065-09-16" },
      { engYear: 2009, yStartInBS: "2065-09-17", yEndInBS: "2066-09-16" },
      { engYear: 2010, yStartInBS: "2066-09-17", yEndInBS: "2067-09-16" },
      { engYear: 2011, yStartInBS: "2067-09-17", yEndInBS: "2068-09-16" },
      { engYear: 2012, yStartInBS: "2068-09-17", yEndInBS: "2069-09-16" },
      { engYear: 2013, yStartInBS: "2069-09-17", yEndInBS: "2070-09-16" },
      { engYear: 2014, yStartInBS: "2070-09-17", yEndInBS: "2071-09-16" },
      { engYear: 2015, yStartInBS: "2071-09-17", yEndInBS: "2072-09-16" },
      { engYear: 2016, yStartInBS: "2072-09-17", yEndInBS: "2073-09-16" },
      { engYear: 2017, yStartInBS: "2073-09-17", yEndInBS: "2074-09-16" },
      { engYear: 2018, yStartInBS: "2074-09-17", yEndInBS: "2075-09-16" },
      { engYear: 2019, yStartInBS: "2075-09-17", yEndInBS: "2076-09-15" },
      { engYear: 2020, yStartInBS: "2076-09-16", yEndInBS: "2077-09-16" },
      { engYear: 2021, yStartInBS: "2077-09-17", yEndInBS: "2078-09-16" },
      { engYear: 2022, yStartInBS: "2078-09-17", yEndInBS: "2079-09-16" },
      { engYear: 2023, yStartInBS: "2079-09-17", yEndInBS: "2080-09-15" },
      { engYear: 2024, yStartInBS: "2080-09-16", yEndInBS: "2081-09-16" },
      { engYear: 2025, yStartInBS: "2081-09-17", yEndInBS: "2082-09-16" },
      { engYear: 2026, yStartInBS: "2082-09-17", yEndInBS: "2083-09-16" },
      { engYear: 2027, yStartInBS: "2083-09-17", yEndInBS: "2084-09-16" },
      { engYear: 2028, yStartInBS: "2084-09-17", yEndInBS: "2085-09-16" },
      { engYear: 2029, yStartInBS: "2085-09-17", yEndInBS: "2086-09-16" },
      { engYear: 2030, yStartInBS: "2086-09-17", yEndInBS: "2087-09-15" },
      { engYear: 2031, yStartInBS: "2087-09-16", yEndInBS: "2088-09-15" },
      { engYear: 2032, yStartInBS: "2088-09-16", yEndInBS: "2089-09-16" },
      { engYear: 2033, yStartInBS: "2089-09-17", yEndInBS: "2090-09-16" },
      { engYear: 2034, yStartInBS: "2090-09-17", yEndInBS: "2091-09-15" },
      { engYear: 2035, yStartInBS: "2091-09-16", yEndInBS: "2092-09-15" },
      { engYear: 2036, yStartInBS: "2092-09-16", yEndInBS: "2093-09-16" },
      { engYear: 2037, yStartInBS: "2093-09-17", yEndInBS: "2094-09-16" },
      { engYear: 2038, yStartInBS: "2094-09-17", yEndInBS: "2095-09-16" },
      { engYear: 2039, yStartInBS: "2095-09-17", yEndInBS: "2096-09-16" },
      { engYear: 2040, yStartInBS: "2096-09-17", yEndInBS: "2097-09-16" }
    ];
    return engYearsHash;
  }

 
  ////Codes which might come into future use.
  //GetEngMonthsOfYear(engYear: number): Array<number> {
  //    let engMonthDays = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
  //    //make feb as 29days if it's leap year.
  //    if (this.IsLeapYear(engYear)) {
  //        engMonthDays[1] = 29;
  //    }
  //    return engMonthDays;
  //}
  //IsLeapYear(year: number): boolean {
  //    return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
  //}

  // public GetTodaysEnDate(): EngDateList {
  //   let engDateToday = moment().format('YYYY-MM-DDTHH:mm');
  //   let nepDateToday = this.ConvertEngToNepDate(engDateToday);
  //   return nepDateToday;
  // }



}

