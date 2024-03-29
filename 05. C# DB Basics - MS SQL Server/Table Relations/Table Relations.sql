USE [Geography]

SELECT m.MountainRange, p.PeakName, p.Elevation
	FROM Peaks p
	JOIN Mountains m
	ON p.MountainId = m.Id
	WHERE m.MountainRange = 'Rila'
	ORDER BY p.Elevation DESC