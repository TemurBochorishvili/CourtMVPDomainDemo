type State = State of Order voption

and Order =
| New
| Final of FinalOrder

and FinalOrder =
| Published
| Unpublished


type Command =
| CreateIntercessionOrder
| MarkIntercessionOrderAsFinal
| PublishIntercessionOrder
| UnmarkIntercessionOrderFinal

| CreateCaseOrder
| MarkCaseOrderAsFinal
| PublishCaseOrder
| UnmarkCaseOrderFinal


type Event =
| CreatedIntercessionOrder
| MarkedIntercessionOrderAsFinal
| PublishedIntercessionOrder
| UnmarkedIntercessionOrderFinal

| CreateedCaseOrder
| MarkedCaseOrderAsFinal
| PublishedCaseOrder
| UnmarkedCaseOrderFinal

