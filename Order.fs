// Key ბი მოვუშალო
type State<'CourtKey, 'JudgeKey, 'IntercessionKey, 'CaseKey> =
    State of Order<'CourtKey, 'JudgeKey, 'IntercessionKey, 'CaseKey> voption

and Order<'CourtKey, 'JudgeKey, 'IntercessionKey, 'CaseKey> =
    { Court: 'CourtKey;
      Judge: 'JudgeKey;
      Type: OrderType<'IntercessionKey, 'CaseKey>;
      Status: OrderStatus }

and OrderType<'IntercessionKey, 'CaseKey> =
| AttachedToIntercession of AttachedToIntercessionOrderType<'IntercessionKey>
| AttachedToCase of AttachedToCaseOrderKey<'CaseKey>

and AttachedToIntercessionOrderType<'IntercessionKey> =
    { Key: 'IntercessionKey }
and AttachedToCaseOrderKey<'CaseKey> =
    { Key: 'CaseKey }

and OrderStatus =
| Pending
| Final of FinalOrder

and FinalOrder =
    { PublicationDate: unit;
      Status: FinalOrderStatus }

and FinalOrderStatus =
| Published
| Unpublished




type Command<'IntercessionKey, 'CaseKey> =
| CreateIntercessionOrder of CreateIntercessionOrderCommand<'IntercessionKey>
| CreateCaseOrder of CreateCaseOrderCommand<'CaseKey>
| MarkOrderAsFinal
| PublishOrder
| UnmarkOrderFinal

and CreateIntercessionOrderCommand<'IntercessionKey> =
    { Key: 'IntercessionKey }

and CreateCaseOrderCommand<'CaseKey> =
    { Key: 'CaseKey }




type Event<'IntercessionKey, 'CaseKey> =
| CreatedIntercessionOrder of CreatedIntercessionOrderEvent<'IntercessionKey>
| MarkedIntercessionOrderAsFinal of MarkedIntercessionOrderAsFinalEvent
| PublishedIntercessionOrder of PublishedIntercessionOrderEvent
| UnmarkedIntercessionOrderFinal of UnmarkedIntercessionOrderFinalEvent
| CreateedCaseOrder of CreatedCaseOrderEvent<'CaseKey>
| MarkedCaseOrderAsFinal of MarkedCaseOrderAsFinalEvent
| PublishedCaseOrder of PublishedCaseOrderEvent
| UnmarkedCaseOrderFinal of UnmarkedCaseOrderFinalEvent

and CreatedIntercessionOrderEvent<'IntercessionKey> =
    { Key: 'IntercessionKey;
      Time: unit }

and MarkedIntercessionOrderAsFinalEvent =
    { Time: unit }

and PublishedIntercessionOrderEvent =
    { Time: unit }

and UnmarkedIntercessionOrderFinalEvent =
    { Time: unit }

and CreatedCaseOrderEvent<'CaseKey> =
    { Key: 'CaseKey;
      Time: unit }

and MarkedCaseOrderAsFinalEvent =
    { Time: unit }

and PublishedCaseOrderEvent =
    { Time: unit }

and UnmarkedCaseOrderFinalEvent =
    { Time: unit }

