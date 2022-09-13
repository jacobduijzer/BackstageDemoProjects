# Overview

```plantuml
@startuml
testdot
@enduml
```

```plantuml
@startuml
!include https://raw.githubusercontent.com/plantuml-stdlib/C4-PlantUML/master/C4_Context.puml

title Weather Context

Person(customer, "Customer", "A customer of Widgets Limited.")

Enterprise_Boundary(c0, "IT & Weather") {

    System(weather-forecast, "Weather forecasting", "Providing forecasting data for today, this week and longer-term forecasting.")

    System(weather-history, "Weather History", "Responsible for storing and delivering historical weather data.")
}

@enduml
```

```plantuml
@startuml
!include https://raw.githubusercontent.com/plantuml-stdlib/C4-PlantUML/master/C4_Component.puml

title Component diagram for Pizza Order Api - API Application

'Container(spa, "Single Page Application", "javascript and angular", "Provides all the internet banking functionality to customers via their web browser.")
'Container(ma, "Mobile App", "Xamarin", "Provides a limited subset ot the internet banking functionality to customers via their mobile mobile device.")
ContainerQueue(queue, "Message Bus", "RabbitMq", "Order messages")
'System_Ext(mbs, "Mainframe Banking System", "Stores all of the core banking information about customers, accounts, transactions, etc.")

Container_Boundary(api, "Order API Application") {
    Component(orderWorker, "Order Information Worker", "Background Worker", "Subscribes on an order information queue")
    Component(orderService, "Order Handler", "Handler")
    ComponentDb(orderDatabase, "Orders", "PostgreSql")
    
    Rel(orderWorker, orderService, "Order details")
    BiRel(orderService, orderDatabase, "Order Information")
}

Rel(queue, orderWorker, "Order Messages", "Messages")
Rel(orderService, queue, "Delivery Information", "Messages")
@enduml
```

## Forecasting

## History