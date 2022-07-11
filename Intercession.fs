type State<'CaseId, 'JudgeId, 'AvouchId> =
    State of Intercession<'CaseId, 'JudgeId, 'AvouchId> voption

and Intercession<'CaseId, 'JudgeId, 'AvouchId> =
    { Status: IntercessionStatus<'CaseId, 'JudgeId> }

and IntercessionStatus<'CaseId, 'JudgeId> =
| New
| DistributedToSecondaryOffice
| AttachedToTheCase of AttachedToTheCase<'CaseId>
| DistributedToJudge of DistributedToJudge<'JudgeId>

and AttachedToTheCase<'CaseId> =
    { // (Approve/Reject)
      CaseId: 'CaseId;
      Approval: bool; // მოჟნა Date ის Option
      Revoked: bool }

and DistributedToJudge<'JudgeId> =
    { JudgeId: 'JudgeId;
      Status: DistrubutedToJudgeStatus }

and DistrubutedToJudgeStatus =
| Consummated
| Disregard

type Command =
| Arrive
| DistributeToSecondaryOffice
| AttachToTheCase
| DistributeToJudge
| Avoid
| Disregard

type Event =
| Arrived
| DistributedToSecondaryOffice
| AttachedToTheCase
| DistributedToJudge
| Avoided
| Disregarded
