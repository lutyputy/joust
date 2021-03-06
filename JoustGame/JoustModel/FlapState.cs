﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace JoustModel
{
    public class FlapState : IState
    {
        StateMachine stateMachine;
        Ostrich ostrich;

        public FlapState(Ostrich ostrich)
        {
            this.ostrich = ostrich;
            this.stateMachine = ostrich.stateMachine;
        }

        public void Update()
        {
            ostrich.nSpeed = 800;
            ostrich.nAngle = 90;
            Task.Run(() =>
            {
                Thread.Sleep(100);
                stateMachine.Change("fall");
            });
            ostrich.MoveLeftRight();
        }

        public void HandleInput(string command)
        {
            switch (command)
            {
                case "left":
                    ostrich.nSpeed = 600;
                    ostrich.nAngle = 180;
                    break;
                case "right":
                    ostrich.nSpeed = 600;
                    ostrich.nAngle = 0;
                    break;
                default:
                    break;
            }
        }

        public void Enter() { }

        public void Exit() { }
    }
}
