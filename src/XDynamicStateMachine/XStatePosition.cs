﻿using System;

namespace XDynamicStateMachine
{
    public class XStatePosition
    {
        readonly string _state;
        readonly string _action;
        readonly string _actor;

        public XStatePosition(string currentState, string actor, string action)
        {
            if (string.IsNullOrEmpty(currentState))
                throw new ArgumentNullException("currentState");
            if (string.IsNullOrEmpty(actor))
                throw new ArgumentNullException("actor");
            if (string.IsNullOrEmpty(action))
                throw new ArgumentNullException("action");

            _state = currentState;
            _actor = actor;
            _action = action;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + _state.GetHashCode();
                hash = hash * 31 + _action.GetHashCode();
                hash = hash * 31 + _actor.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            var other = obj as XStatePosition;
            return other != null && _state == other._state && _action == other._action && _actor == other._actor;
        }
    }
}