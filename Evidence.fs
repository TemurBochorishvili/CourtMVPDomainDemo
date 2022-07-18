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
| MarkedEvidenceAsAdmissable
| MarkedEvidenceAsInadmissable
| MarkedEvidenceAsDisputable
| MarkedEvidenceAsApparent

and CreatedEvidenceEvent<'CaseKey> =
    { Key: 'CaseKey }
