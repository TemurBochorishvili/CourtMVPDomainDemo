type State<'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> =
    State of Intercession<'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> voption

and Intercession<'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> =
| DistrubutedSecondaryOffice of DistrubutedSecondaryOfficeIntercession<'SecondaryOfficeEmployeeKey>
| DistributedToJudge of DistributedToJudgeIntercession<'JudgeKey>
| AttachedToTheCase of AttachedToTheCaseIntercession<'CaseKey>

and DistrubutedSecondaryOfficeIntercession<'SecondaryOfficeEmployeeKey> =
    { Key: 'SecondaryOfficeEmployeeKey }

and DistributedToJudgeIntercession<'JudgeKey> =
    { Key: 'JudgeKey }

and AttachedToTheCaseIntercession<'CaseKey> =
    { Key: 'CaseKey;
      Approval: bool }




type Command<'SecondaryOfficeEmployeeKey, 'JudgeKey, 'CaseKey> =
| DistributeToSecondaryOffice of DistributeToSecondaryOfficeCommand<'SecondaryOfficeEmployeeKey>
| DistributeToJudge of DistributedToJudgeCommand<'JudgeKey>
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
