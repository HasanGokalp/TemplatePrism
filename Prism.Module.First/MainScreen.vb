Imports Prism.Ioc
Imports Prism.Modularity
Imports Prism.Regions

Public Class MainScreen
    Implements IModule

    Private ReadOnly _regionmanager As IRegionManager

    Public Sub New(regionmanager As IRegionManager)
        _regionmanager = regionmanager
    End Sub

    Public Sub RegisterTypes(containerRegistry As IContainerRegistry) Implements IModule.RegisterTypes
        containerRegistry.Register(Of ViewMain)
        'containerRegistry.RegisterSingleton(Of IRegionManager, RegionManager)()
    End Sub

    Public Sub OnInitialized(containerProvider As IContainerProvider) Implements IModule.OnInitialized
        _regionmanager.RegisterViewWithRegion("MainScreen", GetType(ViewMain))
        'Dim region = containerProvider.Resolve(Of IRegionManager)()
        'region.RegisterViewWithRegion("MainScreen", GetType(ViewMain))
    End Sub

End Class
