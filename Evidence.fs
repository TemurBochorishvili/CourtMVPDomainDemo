type State<'CaseKey> = State of Evidence<'CaseKey> voption

and Evidence<'CaseKey> =
    { Key: 'CaseKey;
      Admissibility: EvidenceAdmissibility }

and EvidenceAdmissibility =
| Inadmissible
| Admissible of AdmissibleEvidence

and AdmissibleEvidence =
| Disputable
| Apparent




type Command<'CaseKey> =
| CreateEvidence of CreateEvidenceCommand<'CaseKey>
| MarkEvidenceAsAdmissable
| MarkEvidenceAsInadmissable
| MarkEvidenceAsDisputable
| MarkEvidenceAsApparent

and CreateEvidenceCommand<'CaseKey> =
    { Key: 'CaseKey }




type Event<'CaseKey> =
| CreatedEvidence of CreatedEvidenceEvent<'CaseKey>
| MarkedEvidenceAsAdmissable of MarkedEvidenceAsAdmissableEvent
| MarkedEvidenceAsInadmissable of MarkedEvidenceAsInadmissableEvent
| MarkedEvidenceAsDisputable of MarkedEvidenceAsDisputableEvent
| MarkedEvidenceAsApparent of MarkedEvidenceAsApparentEvent

and CreatedEvidenceEvent<'CaseKey> =
    { Key: 'CaseKey;
      Time: unit }

and MarkedEvidenceAsAdmissableEvent =
    { Time: unit }

and MarkedEvidenceAsInadmissableEvent =
    { Time: unit }

and MarkedEvidenceAsDisputableEvent =
    { Time: unit }

and MarkedEvidenceAsApparentEvent =
    { Time: unit }
