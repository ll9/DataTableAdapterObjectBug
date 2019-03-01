# Ausgangslage

```c#
datatable1.Meger(dataTable2);
=> Merge Conflict cannot merge Column 'Id' from dataTable1 with dataTable2
=> Cannot merge System.Object with System.String
```

Aus irgendeinen Grund hat die Tabelle anfangs, wenn man selbst eine Tabelle erstellt bei der Id-Spalte den falschen Datentyp. Das Problem lässt sich mit der folgenden Beispielanwendung nicht nachvollziehen (genaue Prüfung notwendig).