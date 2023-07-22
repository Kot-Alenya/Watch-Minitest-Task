﻿using System;

namespace CodeBase.Core.Clock
{
    public class ClockPresenter
    {
        private readonly ClockSceneData _sceneData;
        private readonly ClockModel _model;

        public ClockPresenter(ClockModel model, ClockSceneData sceneData)
        {
            _sceneData = sceneData;
            _model = model;
        }

        public void Initialize() => _model.Initialize();

        public void UpdateModel(float deltaTime) => _model.Update(TimeSpan.FromSeconds(deltaTime));

        public void UpdateDigitalClockView() => _sceneData.DigitalClockView.ShowTime(_model.GetCurrentTime());

        public void UpdateWallClockView() => _sceneData.WallClockView.ShowTime(_model.GetCurrentTime());

        public TimeSpan GetCurrentTime() => _model.GetCurrentTime();

        public void SetCurrentTime(TimeSpan time) => _model.SetCurrentTime(time);
    }
}