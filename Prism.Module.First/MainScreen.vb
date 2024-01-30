Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Regions

Public Class MainScreen
    Implements IModule

    Private ReadOnly _regionmanager As IRegionManager
    Private ReadOnly _chat As ChatService

    Public Sub New(regionmanager As IRegionManager, chat As ChatService)
        _regionmanager = regionmanager
        _chat = chat
        _chat.deneme()
    End Sub

    Public Sub RegisterTypes(containerRegistry As IContainerRegistry) Implements IModule.RegisterTypes
        containerRegistry.Register(Of ViewMain)
        'containerRegistry.Register(Of ChatService)
        'containerRegistry.RegisterSingleton(Of IRegionManager, RegionManager)()
    End Sub

    Public Sub OnInitialized(containerProvider As IContainerProvider) Implements IModule.OnInitialized
        _regionmanager.RegisterViewWithRegion("MainScreen", GetType(ViewMain))
        'Dim region = containerProvider.Resolve(Of IRegionManager)()
        'region.RegisterViewWithRegion("MainScreen", GetType(ViewMain))
    End Sub

End Class
