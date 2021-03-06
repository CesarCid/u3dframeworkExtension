﻿using System;

namespace u3dExtensions.Events
{
	public class DelegateEventListener: IEventListener
	{
		Action m_calback;
		Func<bool> m_deadCall;

		public DelegateEventListener (Action callback,Func<bool> deadCall)
		{
			m_calback = callback;
			m_deadCall = deadCall;
		}

		public DelegateEventListener (Action callback): this(callback,() => false)
		{
			
		}


		#region IEventListener implementation
		public void Call ()
		{
			if(!m_deadCall())
				m_calback();
		}

		public bool IsDead ()
		{
			return m_deadCall();
		}
		#endregion
	}

	public class DelegateEventListener<T>: IEventListener<T>
	{
		Action<T> m_calback;
		Func<bool> m_deadCall;

		public DelegateEventListener (Action<T> callback,Func<bool> deadCall)
		{
			m_calback = callback;
			m_deadCall = deadCall;
		}

		public DelegateEventListener (Action<T> callback): this(callback,() => false)
		{

		}
			
		#region IEventListener implementation

		public void Call (T arg1)
		{
			m_calback(arg1);
		}

		public bool IsDead ()
		{
			return m_deadCall();
		}
		#endregion
	}

	public class DelegateEventListener<T,J>: IEventListener<T,J>
	{
		Action<T,J> m_calback;
		Func<bool> m_deadCall;

		public DelegateEventListener (Action<T,J> callback,Func<bool> deadCall)
		{
			m_calback = callback;
			m_deadCall = deadCall;
		}

		public DelegateEventListener (Action<T,J> callback): this(callback,() => false)
		{

		}

		#region IEventListener implementation

		public void Call (T arg1, J arg2)
		{
			m_calback(arg1,arg2);
		}

		public bool IsDead ()
		{
			return m_deadCall();
		}
		#endregion
	}

	public class DelegateEventListener<T,J,K>: IEventListener<T,J,K>
	{
		Action<T,J,K> m_calback;
		Func<bool> m_deadCall;

		public DelegateEventListener (Action<T,J,K> callback,Func<bool> deadCall)
		{
			m_calback = callback;
			m_deadCall = deadCall;
		}

		public DelegateEventListener (Action<T,J,K> callback): this(callback,() => false)
		{

		}

		#region IEventListener implementation

		public void Call (T arg1, J arg2,K arg3)
		{
			m_calback(arg1,arg2,arg3);
		}

		public bool IsDead ()
		{
			return m_deadCall();
		}
		#endregion
	}

	public class DelegateEventListener<T,J,K,W>: IEventListener<T,J,K,W>
	{
		Action<T,J,K,W> m_calback;
		Func<bool> m_deadCall;

		public DelegateEventListener (Action<T,J,K,W> callback,Func<bool> deadCall)
		{
			m_calback = callback;
			m_deadCall = deadCall;
		}

		public DelegateEventListener (Action<T,J,K,W> callback): this(callback,() => false)
		{

		}

		#region IEventListener implementation

		public void Call (T arg1, J arg2,K arg3,W arg4)
		{
			m_calback(arg1,arg2,arg3,arg4);
		}

		public bool IsDead ()
		{
			return m_deadCall();
		}
		#endregion
	}
}

