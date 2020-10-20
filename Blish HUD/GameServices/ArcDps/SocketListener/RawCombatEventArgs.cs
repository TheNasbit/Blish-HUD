﻿using System;
using Blish_HUD.ArcDps.Models;

namespace Blish_HUD.ArcDps {

    public class RawCombatEventArgs : EventArgs {

        public enum CombatEventType {

            /// <summary>
            /// ArcDps calculations and display values.
            /// </summary>
            Area,
            /// <summary>
            /// Local recording of just the own character similar to the in-game combat log in the chat window.
            /// </summary>
            Local

        }

        public CombatEventType EventType { get; }

        public CombatEvent CombatEvent { get; }

        public RawCombatEventArgs(CombatEvent combatEvent, CombatEventType eventType) {
            this.CombatEvent = combatEvent;
            this.EventType   = eventType;
        }

    }

}