﻿SELECT COUNTRY.CONTINENT, FLOOR(AVG(CITY.POPULATION)) 
  FROM COUNTRY 
    INNER JOIN CITY 
            ON COUNTRY.CODE = CITY.COUNTRYCODE 
GROUP BY COUNTRY.CONTINENT;
    