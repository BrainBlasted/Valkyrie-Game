using System;
using System.Runtime.CompilerServices;

namespace GodotEngine
{
	public interface IAwaiter : INotifyCompletion
	{
		bool IsCompleted { get; }

		void GetResult();
	}

	public interface IAwaiter<out TResult> : INotifyCompletion
	{
		bool IsCompleted { get; }

		TResult GetResult();
	}
}