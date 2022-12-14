-- Students

-- 1
SELECT * FROM Students WHERE DoB > '1990';

-- 2
SELECT Firstname, Lastname, Year(Getdate()) - Year(dob) AS Age
FROM   Students
WHERE  country IN ( 'Georgia', 'Libya' ); 

-- 3
INSERT INTO Students (Firstname, Lastname, DoB, Email, Quiz1, Quiz2, MIddleTest, FinalTest, Country)
VALUES ('Giga', 'Ananidze', '2001-10-31', 'giga@gmail.com', 15, 15, 40, 19, 'Georgia');

-- 4
SELECT TOP(5) WITH TIES Firstname, MIddleTest FROM Students order by MiddleTest ASC

-- 5
DELETE FROM Students OUTPUT DELETED.* WHERE FinalTest = 19;

-- 6
UPDATE Students SET FinalTest = 0 OUTPUT INSERTED.* WHERE MiddleTest = 1;


-- PERSONS 


-- 1
SELECT * FROM Persons WHERE PrivateId LIKE '163%';

-- 2
SELECT * FROM Persons WHERE Lastname = City;

-- 3
SELECT * FROM Persons WHERE Country in ('Canada', 'Monaco');

-- 4
SELECT Firstname, Lastname, PrivateId FROM Persons WHERE Email is null;

-- 5
SELECT * FROM Persons WHERE Country in ('Spain', 'Turkey') AND Salary BETWEEN 1000 AND 30000

-- 6
SELECT Workplace FROM Persons WHERE Workplace LIKE '%LLC%' or Workplace LIKE 'PC' or Workplace LIKE 'LLP';

-- 7
SELECT Email,
    CASE
        WHEN LEN(Email) - LEN(REPLACE(Email, '.', '')) > 2 THEN 'more than 2 dots'
        ELSE 'less than 2 dots'
    END AS MailInfo 
FROM Persons;


-- 8
SELECT * FROM Persons WHERE PINcode LIKE '%51';

-- 9
SELECT COUNTRY, AVG(Salary) AS AVERAGE FROM Persons GROUP BY Country;