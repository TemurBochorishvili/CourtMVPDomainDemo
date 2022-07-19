// Key ბი მოვუშალო
type State<'Court, 'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> =
    State of Intercession<'Court, 'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> voption

and Intercession<'Court, 'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> =
    { Court: 'Court;
      Status: IntercessionStatus<'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> }

and IntercessionStatus<'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> =
| AtSecondaryOffice of AtSecondaryOfficeIntercession<'SecondaryOfficeEmployeeKey>
| AtJudge of AtJudgeIntercession<'JudgeKey>
| AttachedToTheCase of AttachedToTheCaseIntercession<'CaseKey>
// გამოთხოვილი

and AtSecondaryOfficeIntercession<'SecondaryOfficeEmployeeKey> = // მეორად კანცელარიაშია მარა არავისთან
    { Key: 'SecondaryOfficeEmployeeKey voption }

and AtJudgeIntercession<'JudgeKey> =
    { Key: 'JudgeKey voption }

and AttachedToTheCaseIntercession<'CaseKey> =
    { Key: 'CaseKey;
      Approval: bool }




type Command<'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> =
| WavidaMeoradshi
| GanawildaMeoradisTanamSromelze
// თუ განრიგიდან ამოაგდეს
| DistributeToSecondaryOffice of DistributeToSecondaryOfficeCommand<'SecondaryOfficeEmployeeKey>
// | DistributeToJudge of DistributedToJudgeCommand<'JudgeKey>
| WavidaGasanawilebelshi
| GanawildaMosamarTleze
| AttachToTheCase of AttachedToTheCaseCommand<'CaseKey>
| Approve
| Reject
| Avoid
| Disregard

and DistributeToSecondaryOfficeCommand<'SecondaryOfficeEmployeeKey> =
    { Key: 'SecondaryOfficeEmployeeKey }

and DistributedToJudgeCommand<'JudgeKey> =
    { Key: 'JudgeKey }

and AttachedToTheCaseCommand<'CaseKey> =
    { Key: 'CaseKey }




type Event<'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> =
| DistributedToSecondaryOffice of DistributedToSecondaryOfficeEvent<'SecondaryOfficeEmployeeKey>
| DistributedToJudge of DistributedToJudgeEvent<'JudgeKey>
| AttachedToTheCase of AttachedToTheCaseEvent<'CaseKey>
| Approved of ApprovedEvent
| Avoided of AvoidedEvent
| Disregarded of DisregardedEvent

and DistributedToSecondaryOfficeEvent<'SecondaryOfficeEmployeeKey> =
    { Key: 'SecondaryOfficeEmployeeKey;
      Time: unit }

and DistributedToJudgeEvent<'JudgeKey> =
    { Key: 'JudgeKey;
      Time: unit }

and AttachedToTheCaseEvent<'CaseKey> =
    { Key: 'CaseKey;
      Time: unit }

and ApprovedEvent =
    { Time: unit }

and AvoidedEvent =
    { Time: unit }

and DisregardedEvent =
    { Time: unit }
