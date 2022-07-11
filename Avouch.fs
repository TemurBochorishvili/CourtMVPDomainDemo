type State<'IntercessionId, 'LibelId, 'CaseId> =
    State of Avouch<'IntercessionId, 'LibelId, 'CaseId> voption

type Avouch<'IntercessionId, 'LibelId, 'CaseId> =
    { Status: AvouchStatus<'IntercessionId, 'LibelId, 'CaseId> }

and AvouchStatus<'IntercessionId, 'LibelId, 'CaseId> =
| New
| DistributedToSecondaryOffice
| Attached of AvouchAttachStatus<'IntercessionId, 'LibelId, 'CaseId>

and AvouchAttachStatus<'IntercessionId, 'LibelId, 'CaseId> =
    { React: ReactedAvouch voption;
      Type: AvouchType<'IntercessionId, 'LibelId, 'CaseId> }

and AvouchType<'IntercessionId, 'LibelId, 'CaseId> =
| ToIntercession of 'IntercessionId
| ToLibel of 'LibelId
| ToCase of 'CaseId

and ReactedAvouch = ReactedAvouch
