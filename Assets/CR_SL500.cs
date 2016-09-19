// Decompiled with JetBrains decompiler
// Type: AdminCard.CR_SL500
// Assembly: AdminCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19B2980C-B4F8-479C-8326-81DC35A6E28D
// Assembly location: E:\$$KASSA_phoenix\AdminCard\AdminCard.exe

using System.Runtime.InteropServices;

namespace AdminCard
{
  internal class CR_SL500
  {
    [DllImport("CR_SL500.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int Initialize(short ComPort);

    [DllImport("CR_SL500.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int Deinitialize();

    [DllImport("CR_SL500.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int CardConnect();

    [DllImport("CR_SL500.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int CardDisconnect();

    [DllImport("CR_SL500.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int ReadRawTrack(int TrackNo, byte[] OutTrack, int TrackSize);

    [DllImport("CR_SL500.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int WriteRawTrack(int TrackNo, byte[] Track, int TrackSize);

    [DllImport("CR_SL500.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int Verify(uint Data);

    [DllImport("CR_SL500.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int ReadSerial(byte[] SerialCode);
  }
}
