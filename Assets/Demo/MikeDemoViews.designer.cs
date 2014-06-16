// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Linq;
using UnityEngine;


[DiagramInfoAttribute("MikeDemo")]
public abstract class CubeGameViewBase : ViewBase {
    
    [UFToggleGroup("BaseProperty")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("BasePropertyChanged")]
    public bool _BindBaseProperty;
    
    [UFGroup("BaseProperty")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetBasePropertyTwoWayValue")]
    public bool _BasePropertyIsTwoWay;
    
    [UFToggleGroup("Cubes")]
    [UnityEngine.HideInInspector()]
    public bool _BindCubes;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public string _BaseProperty;
    
    public override System.Type ViewModelType {
        get {
            return typeof(CubeGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public CubeGameViewModel CubeGame {
        get {
            return ((CubeGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void BasePropertyChanged(string value) {
    }
    
    public virtual string GetBasePropertyTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public virtual void CubesAdded(string item) {
    }
    
    public virtual void CubesRemoved(string item) {
    }
    
    public override void Bind() {
        if (this._BindBaseProperty) {
            if (this._BasePropertyIsTwoWay) {
                this.BindProperty(()=>CubeGame._BasePropertyProperty, this.BasePropertyChanged, this.GetBasePropertyTwoWayValue);
            }
            else {
                this.BindProperty(()=>CubeGame._BasePropertyProperty, this.BasePropertyChanged);
            }
        }
        if (this._BindCubes) {
            var binding = this.BindCollection(() => CubeGame._CubesProperty);
            binding.SetAddHandler(CubesAdded);
            binding.SetRemoveHandler(CubesRemoved);
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CubeGameController>());
    }
    
    public virtual void ExecuteEndGame() {
        this.ExecuteCommand(CubeGame.EndGame);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        CubeGameViewModel cubeGame = ((CubeGameViewModel)(viewModel));
        cubeGame.BaseProperty = this._BaseProperty;
    }
}

[DiagramInfoAttribute("MikeDemo")]
public abstract class CoolCubeGameViewBase : CubeGameViewBase {
    
    [UFToggleGroup("DerivedProperty")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("DerivedPropertyChanged")]
    public bool _BindDerivedProperty;
    
    [UFGroup("DerivedProperty")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetDerivedPropertyTwoWayValue")]
    public bool _DerivedPropertyIsTwoWay;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public string _DerivedProperty;
    
    public override System.Type ViewModelType {
        get {
            return typeof(CoolCubeGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public CoolCubeGameViewModel CoolCubeGame {
        get {
            return ((CoolCubeGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void DerivedPropertyChanged(string value) {
    }
    
    public virtual string GetDerivedPropertyTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindDerivedProperty) {
            if (this._DerivedPropertyIsTwoWay) {
                this.BindProperty(()=>CoolCubeGame._DerivedPropertyProperty, this.DerivedPropertyChanged, this.GetDerivedPropertyTwoWayValue);
            }
            else {
                this.BindProperty(()=>CoolCubeGame._DerivedPropertyProperty, this.DerivedPropertyChanged);
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CoolCubeGameController>());
    }
    
    public virtual void ExecutePlay() {
        this.ExecuteCommand(CoolCubeGame.Play);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        CoolCubeGameViewModel coolCubeGame = ((CoolCubeGameViewModel)(viewModel));
        coolCubeGame.DerivedProperty = this._DerivedProperty;
    }
}

public partial class CubeGameView : CubeGameViewBase {
}

public partial class CoolCubeGameView : CoolCubeGameViewViewBase {
}

[DiagramInfoAttribute("MikeDemo")]
public abstract class CoolCubeGameViewViewBase : CubeGameView {
    
    [UFToggleGroup("DerivedProperty")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("DerivedPropertyChanged")]
    public bool _BindDerivedProperty;
    
    [UFGroup("DerivedProperty")]
    [UnityEngine.HideInInspector()]
    [UFRequireInstanceMethod("GetDerivedPropertyTwoWayValue")]
    public bool _DerivedPropertyIsTwoWay;
    
    [UFGroup("View Model Properties")]
    [UnityEngine.HideInInspector()]
    public string _DerivedProperty;
    
    public override System.Type ViewModelType {
        get {
            return typeof(CoolCubeGameViewModel);
        }
    }
    
    public override bool IsMultiInstance {
        get {
            return false;
        }
    }
    
    public CoolCubeGameViewModel CoolCubeGame {
        get {
            return ((CoolCubeGameViewModel)(this.ViewModelObject));
        }
        set {
            this.ViewModelObject = value;
        }
    }
    
    public virtual void DerivedPropertyChanged(string value) {
    }
    
    public virtual string GetDerivedPropertyTwoWayValue() {
        throw new System.NotImplementedException();
    }
    
    public override void Bind() {
        base.Bind();
        if (this._BindDerivedProperty) {
            if (this._DerivedPropertyIsTwoWay) {
                this.BindProperty(()=>CoolCubeGame._DerivedPropertyProperty, this.DerivedPropertyChanged, this.GetDerivedPropertyTwoWayValue);
            }
            else {
                this.BindProperty(()=>CoolCubeGame._DerivedPropertyProperty, this.DerivedPropertyChanged);
            }
        }
    }
    
    public override ViewModel CreateModel() {
        return this.RequestViewModel(GameManager.Container.Resolve<CoolCubeGameController>());
    }
    
    public virtual void ExecutePlay() {
        this.ExecuteCommand(CoolCubeGame.Play);
    }
    
    protected override void InitializeViewModel(ViewModel viewModel) {
        base.InitializeViewModel(viewModel);
        CoolCubeGameViewModel coolCubeGame = ((CoolCubeGameViewModel)(viewModel));
        coolCubeGame.DerivedProperty = this._DerivedProperty;
    }
}