// Key ბი მოვუშალო
type State<'CourtKey, 'SecondaryOfficeEmployeeKey, 'IntercessionKey, 'CaseKey> =
    State of Avouch<'CourtKey, 'SecondaryOfficeEmployeeKey, 'IntercessionKey, 'CaseKey> voption

and Avouch<'CourtKey, 'SecondaryOfficeEmployeeKey, 'IntercessionKey, 'CaseKey> =
    { Court: 'CourtKey;
      Status: AvouchStatus<'SecondaryOfficeEmployeeKey, 'IntercessionKey, 'CaseKey> }

and AvouchStatus<'SecondaryOfficeEmployeeKey, 'IntercessionKey, 'CaseKey> =
| DistributedToSecondaryOffice of DistributeAvouchToSecondaryOffice<'SecondaryOfficeEmployeeKey>
| Attached of AvouchAttachStatus<'IntercessionKey, 'CaseKey>

and DistributeAvouchToSecondaryOffice<'SecondaryOfficeEmployeeKey> =
    { Key: 'SecondaryOfficeEmployeeKey }

and AvouchAttachStatus<'IntercessionKey, 'CaseKey> =
    { Type: AvouchType<'IntercessionKey, 'CaseKey>;
      React: ReactedAvouch voption }

and AvouchType<'IntercessionKey, 'CaseKey> =
| Intercession of 'IntercessionKey
| Case of 'CaseKey

and ReactedAvouch = ReactedAvouch // გიორგას ვკითხოთ გვჭირდება თუ არა რეაგირება აქ. P.S ეს უბრალო ინფოა და არანირ დოკ ფლოუში მონაწილეობას არ იღებს




type Command<'SecondaryOfficeEmployeeKey, 'IntercessionKey, 'CaseKey> =
// | DistributeAvouchToSecondaryOffice of DistributeAvouchToSecondaryOfficeCommand<'SecondaryOfficeEmployeeKey>
| WavidaMeoradshi
| GanawildaMeoradisTanamSromelze
| AttachAvouchToIntercession of AttachAvouchToIntercessionCommand<'IntercessionKey>
| AttachAvouchToCase of AttachAvouchToCaseCommand<'CaseKey>
| ReactOnAvouch

and DistributeAvouchToSecondaryOfficeCommand<'SecondaryOfficeEmployeeKey> =
    { Key: 'SecondaryOfficeEmployeeKey }

and AttachAvouchToIntercessionCommand<'IntercessionKey> =
    { Key: 'IntercessionKey }

and AttachAvouchToCaseCommand<'CaseKey> =
    { Key: 'CaseKey }




type Event<'SecondaryOfficeEmployeeKey, 'IntercessionKey, 'CaseKey> =
| CreateedAvouch of CreatedEvent
| DistributeedAvouchToSecondaryOffice of DistributedAvouchToSecondaryOfficeEvent<'SecondaryOfficeEmployeeKey>
| AttachedAvouchToIntercession of AttachedAvouchToIntercessionEvent<'IntercessionKey>
| AttachedAvouchToCase of AttachedAvouchToCaseEvent<'CaseKey>
| ReactOnAvouch of ReactOnAvouchEvent

and CreatedEvent =
    { Time: unit }

and DistributedAvouchToSecondaryOfficeEvent<'SecondaryOfficeEmployeeKey> =
    { Key: 'SecondaryOfficeEmployeeKey;
      Time: unit }

and AttachedAvouchToIntercessionEvent<'IntercessionKey> =
    { Key: 'IntercessionKey;
      Time: unit }

and AttachedAvouchToCaseEvent<'CaseKey> =
    { Key: 'CaseKey;
      Time: unit }

and ReactOnAvouchEvent =
    { Time: unit }
