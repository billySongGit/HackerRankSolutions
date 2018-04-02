/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT COUNTRY.CONTINENT, FLOOR(AVG(CITY.POPULATION)) 
  FROM COUNTRY 
    INNER JOIN CITY 
            ON COUNTRY.CODE = CITY.COUNTRYCODE 
GROUP BY COUNTRY.CONTINENT;
    