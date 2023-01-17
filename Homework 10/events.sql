select * from Event
select * from Country
select * from Continent

-- 1
SELECT COUNT(*) FROM event 
WHERE countryid IN ( SELECT continentid FROM country 
WHERE continentid IN ( SELECT continentid FROM continent 
    WHERE continentname IN ('Europe')
    )
)

-- 2
SELECT min(EventDate) FROM event 
WHERE countryid IN ( SELECT continentid FROM country 
WHERE continentid IN ( SELECT continentid FROM continent 
    WHERE continentname IN ('Africa')
    )
)

-- 3
SELECT COUNT(*) FROM country 
WHERE continentid IN (
    SELECT continentid  FROM continent 
        WHERE continentname IN ('South America', 'North America')
)