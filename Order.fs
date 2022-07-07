type State<'IntercessionId, 'LibelId, 'CaseId> =
    State of Order<'IntercessionId, 'LibelId, 'CaseId> voption

and Order<'IntercessionId, 'LibelId, 'CaseId> =
| Intercession of 'IntercessionId
| Libel of 'LibelId
| Case of 'CaseId
| OnTheFly
// განჩინება რომელიც წინაპირობის გარეშე შეუძლია გამოიტანოს +
// განჩინებას ეხლა აქ ესეთი სთეითები:
    // შექმნილი
    // საბოლოო (საბოლოო შეიძლება მისცეს რო 2 საათში გაუშვიო და ამ 2 საათში შეუძლია საბოლოო მოხსნას)
        // გამოქვეყნებული
        // გამოუქვეყნებელი
    // კანონიერ ძალაში შესვლის თარიღი(გვჭირდება თუ არა ამ სერვისში)
    // ? ცნობის საკითხი ?
        // თამარასთან გავარკვიო ეს ცნობა რა ფორმატისაა და საჭიროა მერე მაგის ცალკე გატანა?

type Command =
| PublishIntercessionOrder
| PublishLibelOrder
| PublishCaseOrder

type Event =
| PublishedIntercessionOrder
| PublishedLibelOrder
| PublishedCaseOrder
