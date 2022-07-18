type State<'IntercessionKey, 'CaseKey> =
    State of Order<'IntercessionKey, 'CaseKey> voption

and Order<'IntercessionKey, 'CaseKey> =
    { Type: OrderType<'IntercessionKey, 'CaseKey>;
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
| MarkIntercessionOrderAsFinal
| PublishIntercessionOrder
| UnmarkIntercessionOrderFinal
| CreateCaseOrder of CreateCaseOrderCommand<'CaseKey>
| MarkCaseOrderAsFinal
| PublishCaseOrder
| UnmarkCaseOrderFinal

and CreateIntercessionOrderCommand<'IntercessionKey> =
    { Key: 'IntercessionKey }

and CreateCaseOrderCommand<'CaseKey> =
    { Key: 'CaseKey }




type Event<'IntercessionKey, 'CaseKey> =
| CreatedIntercessionOrder of CreatedIntercessionOrderEvent<'IntercessionKey>
| MarkedIntercessionOrderAsFinal
| PublishedIntercessionOrder
| UnmarkedIntercessionOrderFinal
| CreateedCaseOrder of CreatedCaseOrderEvent<'CaseKey>
| MarkedCaseOrderAsFinal
| PublishedCaseOrder
| UnmarkedCaseOrderFinal

and CreatedIntercessionOrderEvent<'IntercessionKey> =
    { Key: 'IntercessionKey }

and CreatedCaseOrderEvent<'CaseKey> =
    { Key: 'CaseKey }
