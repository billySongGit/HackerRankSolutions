/*
Enter your query here.
Please append a semicolon ";" at the end of the query and enter your query in a single line to avoid error.
*/
SELECT CASE WHEN GRADE < 8 THEN 'NULL'
	   ELSE STUDENTS.NAME END, GRADES.GRADE, STUDENTS.MARKS
  FROM STUDENTS, GRADES
 WHERE MARKS BETWEEN GRADES.MIN_MARK AND GRADES.MAX_MARK
ORDER BY GRADE DESC, STUDENTS.NAME;